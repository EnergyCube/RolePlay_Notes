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
        echo "Success";
    } else {
        echo "Error";
    }

    // Closing Connection
    $pdo = null;
} else {
    die("Check Args");
}

?>