<?php

include("api.php");

$post_username = $_POST['username'];
$post_password = $_POST['password'];
$post_group = $_POST['group'];

if (CheckLoginArgs($post_username, $post_password, $post_group)) {

    $db_name = $post_group;

    try {
        $pdo = new PDO("mysql:host=$db_host; dbname=$db_name", $db_user, $db_password);
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        $pdo->setAttribute(PDO::ATTR_EMULATE_PREPARES, false);
    } catch (PDOException $e) {
        echo 'Database error : ' . $e->getMessage();
    }

    if (Login($pdo, $post_username, $post_password)) {
        if ($_POST['action'] == 'get') {
            GetMoneyJSON($pdo);
        } else if ($_POST['action'] == 'getfromusername') {
            if (!IsNullOrEmptyString($_POST['targetuser'])) {
                GetMoney($pdo, $_POST['targetuser']);
            } else {
                echo "Check Args";
            }
        } else if ($_POST['action'] == 'edit') {
            if (GetUserPermission($pdo, $post_username) != 'low') {
                if (!IsNullOrEmptyString($_POST['targetuser']) && !IsNullOrEmptyString($_POST['money'])
                    && !IsNullOrEmptyString($_POST['type'])) {
                    if ($_POST['type'] == "perso") {
                        if(EditMoneyPerso($pdo, $_POST['targetuser'],  $_POST['money'])) {
                            echo "Success";
                        } else {
                            echo "Error";
                        }
                    } else if ($_POST['type'] == "group") {
                        if(EditMoneyGroup($pdo, $_POST['targetuser'],  $_POST['money'])) {
                            echo "Success";
                        } else {
                            echo "Error";
                        }
                    } else {
                        echo 'Unknown Type';
                    }
                } else {
                    echo "Check Args";
                }
            } else {
                echo "Access Denied";
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