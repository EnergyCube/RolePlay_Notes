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
        if ($_POST['action'] == 'getfull') {
            GetRenseignementsJSON($pdo, true);
        } else if ($_POST['action'] == 'getlite') {
            GetRenseignementsJSON($pdo, false);
        } else if ($_POST['action'] == 'getfromid') {
            if (!IsNullOrEmptyString($_POST['id'])) {
                GetRenseignementFromIdJSON($pdo, $_POST['id']);
            }
        } else if ($_POST['action'] == 'search') {
            GetRenseignementFromFilterJSON($pdo, $_POST['nickname'], $_POST['name'],
                $_POST['pseudo'],  $_POST['tel'], $_POST['affiliation'],
                $_POST['old_affiliation'], $_POST['position'], $_POST['license_plate'],
                $_POST['known_vehicle'], $_POST['financial_situation'], $_POST['behaviour'],
                $_POST['dead'], $_POST['wanted'], $_POST['fake_nickname'], $_POST['fake_name'],
                $_POST['min_last_edit_date']);
        } else if($_POST['action'] == 'add'){
            if(CreateRenseignement($pdo, $_POST['nickname'], $_POST['name'],
                $_POST['pseudo'],  $_POST['tel'], $_POST['affiliation'],
                $_POST['old_affiliation'], $_POST['position'], $_POST['license_plate'],
                $_POST['known_vehicle'], $_POST['financial_situation'], $_POST['behaviour'],
                $_POST['info'], $_POST['info_hrp'], $_POST['dead'], $_POST['wanted'],
                $_POST['wanted_since'], $_POST['fake_nickname'], $_POST['fake_name'], $post_username)) {
                echo "Success";
            } else {
                echo "Error";
            }
        } else if ($_POST['action'] == 'edit') {
            if (GetUserPermission($pdo, $post_username) != 'low') {
                if (!IsNullOrEmptyString($_POST['id'])) {
                    if(EditRenseignement($pdo, $_POST['id'], $_POST['nickname'], $_POST['name'],
                        $_POST['pseudo'],  $_POST['tel'], $_POST['affiliation'],
                        $_POST['old_affiliation'], $_POST['position'], $_POST['license_plate'],
                        $_POST['known_vehicle'], $_POST['financial_situation'], $_POST['behaviour'],
                        $_POST['info'], $_POST['info_hrp'], $_POST['dead'], $_POST['wanted'],
                        $_POST['wanted_since'], $_POST['fake_nickname'], $_POST['fake_name'], $post_username)) {
                        echo "Success";
                    } else {
                        echo "Error";
                    }
                } else {
                    echo "Check Args";
                }
            } else {
                echo "Invalid Permission";
            }
        } else if ($_POST['action'] == 'del') {
            if (GetUserPermission($pdo, $post_username) != 'low') {
                if (!IsNullOrEmptyString($_POST['id'])) {
                    if (DeleteRenseignement($pdo, $_POST['id'])) {
                        echo "Success";
                    } else {
                        echo "Error";
                    }
                } else {
                    echo "Check Args";
                }
            } else {
                echo "Invalid Permission";
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