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
        if ($_POST['type'] == 'ressource_type') { /* Ressource Type */
            if ($_POST['action'] == 'add') { 
                if (GetUserPermission($pdo, $post_username) == 'max') {
                    if (!IsNullOrEmptyString($_POST['name'])) {
                        if (CreateRessourceType($pdo, $_POST['name'], $_POST['mass'],
                            $_POST['price'], $_POST['icon'])) {
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
                    if (!IsNullOrEmptyString($_POST['id'])) {
                        if (EditRessourceType($pdo, $_POST['id'], $_POST['name'], $_POST['oldname'],
                            $_POST['mass'], $_POST['price'], $_POST['icon'])) {
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
                if (GetUserPermission($pdo, $post_username) == 'max') {
                    if (!IsNullOrEmptyString($_POST['id'])) {
                        if(DeleteRessourceType($pdo, $_POST['id'])) {
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
                GetRessourceTypeJSON($pdo);
            } else if ($_POST['action'] == 'getfromid') {
                if (!IsNullOrEmptyString($_POST['id'])) {
                    GetRessourceTypeFromIdJSON($pdo, $_POST['id']);
                } else {
                    echo "Check Args";
                }
            } else {
                echo "Unknown Action";
            }
        } else if ($_POST['type'] == 'storage_type') { /* Storage Type */
            if ($_POST['action'] == 'add') { 
                if (GetUserPermission($pdo, $post_username) == 'max') {
                    if (!IsNullOrEmptyString($_POST['name'])) {
                        if (CreateStorageType($pdo, $_POST['name'], $_POST['size'])) {
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
                    if (!IsNullOrEmptyString($_POST['id'])) {
                        if (EditStorageType($pdo, $_POST['id'], $_POST['name'], $_POST['size'])) {
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
                if (GetUserPermission($pdo, $post_username) == 'max') {
                    if (!IsNullOrEmptyString($_POST['id'])) {
                        if(DeleteStorageType($pdo, $_POST['id'])) {
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
                GetStorageTypeJSON($pdo);
            } else if ($_POST['action'] == 'getfromid') {
                if (!IsNullOrEmptyString($_POST['id'])) {
                    GetStorageTypeFromIdJSON($pdo, $_POST['id']);
                } else {
                    echo "Check Args";
                }
            } else {
                echo "Unknown Action";
            }
        } else if ($_POST['type'] == 'storage') { /* Storage */
            if ($_POST['action'] == 'add') { 
                if (GetUserPermission($pdo, $post_username) == 'max') {
                    if (!IsNullOrEmptyString($_POST['owner']) && !IsNullOrEmptyString($_POST['name']
                        && !IsNullOrEmptyString($_POST['storage_type']) && !IsNullOrEmptyString($_POST['location']))) {
                        if (CreateStorage($pdo, $_POST['owner'], $_POST['name'], $_POST['storage_type'], $_POST['location'])) {
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
                if (GetUserPermission($pdo, $post_username) == 'med') {
                    if (!IsNullOrEmptyString($_POST['owner']) && !IsNullOrEmptyString($_POST['name']
                        && !IsNullOrEmptyString($_POST['storage_type']) && !IsNullOrEmptyString($_POST['location'])
                        && !IsNullOrEmptyString($_POST['data']))) {
                        if (EditStorage($pdo, $_POST['id'], $_POST['owner'],
                            $_POST['name'], $_POST['storage_type'], $_POST['location'], $_POST['data'])) {
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
                if (GetUserPermission($pdo, $post_username) == 'max') {
                    if (!IsNullOrEmptyString($_POST['id'])) {
                        if(DeleteStorage($pdo, $_POST['id'])) {
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
                GetStorageJSON($pdo);
            } else if ($_POST['action'] == 'getfromid') {
                if (!IsNullOrEmptyString($_POST['id'])) {
                    GetStorageFromIdJSON($pdo, $_POST['id']);
                } else {
                    echo "Check Args";
                }
            }
        } else if ($_POST['type'] == 'storage_data') { /* Storage Data */
            if ($_POST['action'] == 'add') { 
                if (GetUserPermission($pdo, $post_username) == 'max') {
                    if (!IsNullOrEmptyString($_POST['ressource_type_id']) && !IsNullOrEmptyString($_POST['quantity']
                        && !IsNullOrEmptyString($_POST['belongto']) && !IsNullOrEmptyString($_POST['storage_id']))) {
                        if (CreateStorageData($pdo, $_POST['ressource_type_id'], $_POST['quantity'],
                            $_POST['belongto'], $_POST['storage_id'])) {
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
                    if (!IsNullOrEmptyString($_POST['id']) && !IsNullOrEmptyString($_POST['ressource_type_id']) 
                        && !IsNullOrEmptyString($_POST['quantity'] && !IsNullOrEmptyString($_POST['belongto'])
                        && !IsNullOrEmptyString($_POST['storage_id']))) {
                        if (EditStorageData($pdo, $_POST['id'], $_POST['ressource_type_id'],
                            $_POST['quantity'], $_POST['belongto'], $_POST['storage_id'])) {
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
                if (GetUserPermission($pdo, $post_username) == 'max') {
                    if (!IsNullOrEmptyString($_POST['id'])) {
                        if(DeleteStorageData($pdo, $_POST['id'])) {
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
                GetStorageDataJSON($pdo);
            } else if ($_POST['action'] == 'getfromid') {
                if (!IsNullOrEmptyString($_POST['id'])) {
                    GetStorageDataFromIdJSON($pdo, $_POST['id']);
                } else {
                    echo "Check Args !";
                }
            } else if ($_POST['action'] == 'getfromstorageid') {
                if (!IsNullOrEmptyString($_POST['storage_id'])) {
                    GetStorageDataFromStorageIdJSON($pdo, $_POST['storage_id']);
                } else {
                    echo "Check Args";
                }
            } else {
                echo "Unknown Action";
            }
        } else {
            echo 'Unknown Type';
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