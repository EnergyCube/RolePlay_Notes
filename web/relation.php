<?php

include("api.php");

$post_username = $_POST['username'];
$post_password = $_POST['password'];
$post_group = $_POST['group'];

if (CheckLoginArgs($post_username, $post_password, $post_group)) {

    $db_name = $post_group;
    $db_user = 'root';
    $db_password = 'VkQ$bT*O!6d';
    $db_host = 'localhost';

    try {
        $pdo = new PDO("mysql:host=$db_host; dbname=$db_name", $db_user, $db_password);
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        $pdo->setAttribute(PDO::ATTR_EMULATE_PREPARES, false);
    } catch (PDOException $e) {
        echo 'Database error : ' . $e->getMessage();
    }

    if (Login($pdo, $post_username, $post_password)) {
        if ($_POST['action'] == 'add') { 
            if (!IsNullOrEmptyString($_POST['name']) && !IsNullOrEmptyString($_POST['behaviour'])
            && !IsNullOrEmptyString($_POST['strength']) && !IsNullOrEmptyString($_POST['type'])
            && !IsNullOrEmptyString($_POST['financial_situation']) && !IsNullOrEmptyString($_POST['headcount'])
            && !IsNullOrEmptyString($_POST['info'])) {
                    if(CreateRelation($pdo, $_POST['name'], $_POST['behaviour'], $_POST['strength'],
                        $_POST['type'], $_POST['financial_situation'], $_POST['headcount'], $_POST['info'])) {
                        echo "Success";
                    } else {
                        echo "Error";
                    }
                } else {
                    echo "Check Args";
                }
        } else if ($_POST['action'] == 'get') {
            GetRelationDataJSON($pdo);
        } else if ($_POST['action'] == 'getfromid') {
            if (!IsNullOrEmptyString($_POST['id'])) {
                GetRelationFromIdJSON($pdo, $_POST['id']);
            } else {
                echo "Check Args";
            }
        } else if ($_POST['action'] == 'edit') {
            if (GetUserPermission($pdo, $post_username) != 'low') {
                if (!IsNullOrEmptyString($_POST['id']) && !IsNullOrEmptyString($_POST['name'])
                    && !IsNullOrEmptyString($_POST['behaviour']) && !IsNullOrEmptyString($_POST['strength'])
                    && !IsNullOrEmptyString($_POST['type']) && !IsNullOrEmptyString($_POST['financial_situation'])
                    && !IsNullOrEmptyString($_POST['headcount']) && !IsNullOrEmptyString($_POST['info'])) {
                    if(EditRelation($pdo, $_POST['id'], $_POST['name'], $_POST['behaviour'], $_POST['strength'],
                        $_POST['type'], $_POST['financial_situation'], $_POST['headcount'], $_POST['info'])) {
                        echo "Success";
                    } else {
                        echo "Error";
                    }
                } else {
                    echo "Check Args";
                }
            } else {
                echo "Access Denied";
            }
        } else if ($_POST['action'] == 'del') {
            if (!IsNullOrEmptyString($_POST['id'])) {
                DeleteRelation($pdo, $_POST['id']);
            } else {
                echo "Check Args";
            }
        } else {
            echo 'Unknown Action';
        }
    } else {
        echo 'Invalid';
    }

    // Closing Connection
    $pdo = null;
} else {
    die("Check Args");
}

?>