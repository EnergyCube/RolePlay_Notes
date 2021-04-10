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
            if (GetUserPermission($pdo, $post_username) == 'max') {
                if (
                    !IsNullOrEmptyString($_POST['newuser'])
                    && !IsNullOrEmptyString($_POST['newpass'])
                    && !IsNullOrEmptyString($_POST['permission'])
                ) {
                    if (CreateUser($pdo, $_POST['newuser'], $_POST['newpass'], $_POST['renseignementid'], $_POST['permission'])) {
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
        } else if ($_POST['action'] == 'edit') {
            if (GetUserPermission($pdo, $post_username) == 'max') {
                if (
                    !IsNullOrEmptyString($_POST['newuser'])
                    && !IsNullOrEmptyString($_POST['permission'])
                ) {
                    if (IsNullOrEmptyString($_POST['newpass'])) {
                        if (EditUser($pdo, $_POST['newuser'], $_POST['renseignementid'], $_POST['permission'])) {
                            echo "Success";
                        } else {
                            echo "Error";
                        }
                    } else {
                        if (EditUserWithPassword($pdo, $_POST['newuser'], $_POST['newpass'], $_POST['renseignementid'], $_POST['permission'])) {
                            echo "Success";
                        } else {
                            echo "Error";
                        }
                    }
                } else {
                    echo "Check Args";
                }
            } else {
                echo "Access Denied";
            }
        } else if ($_POST['action'] == 'del') {
            if (GetUserPermission($pdo, $post_username) == 'max') {
                if (!IsNullOrEmptyString($_POST['targetuser'])) {
                    if(DeleteUser($pdo, $_POST['targetuser'])) {
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
        } else if ($_POST['action'] == 'get') {
            GetInternalJSON($pdo);
        } else if ($_POST['action'] == 'getfromusername') {
            GetInternalFromUsernameJSON($pdo, $_POST['targetuser']);
        } else {
            echo "Unknown Action";
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