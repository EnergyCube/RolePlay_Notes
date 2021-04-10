<?php

/* Utils */
function IsNullOrEmptyString($str)
{
    return (!isset($str) || trim($str) === '' || empty($str));
}
/* End Utils */

/* Login */
function CheckLoginArgs($username, $pass_unhashed, $group)
{
    if (
        !IsNullOrEmptyString($username)
        && !IsNullOrEmptyString($pass_unhashed)
        && !IsNullOrEmptyString($group)
    ) {
        return true;
    } else {
        return false;
    }
}

function Login($pdo, $username, $pass_unhashed)
{
    try {
        $stmt = $pdo->prepare('SELECT password FROM internal WHERE username=:username;');
        $stmt->execute([':username' => $username]);

        while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
            return ($row['password'] == hash('sha256', $pass_unhashed));
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}
/* End Login */

/* Internal */
function UserExist($pdo, $username)
{
    try {
        $stmt = $pdo->prepare('SELECT username FROM internal WHERE username=:username;');
        $stmt->execute([':username' => $username]);

        $result_array = [];
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
            $result_array[] = $row['username'];

        return count($result_array) > 0;
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function GetUserPermission($pdo, $username)
{
    try {
        $stmt = $pdo->prepare('SELECT permission
            FROM internal WHERE username=:username;');
        $stmt->execute([':username' => $username]);

        while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
            return $row['permission'];
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function CreateUser($pdo, $username, $password_unhashed, $renseignementid, $permission)
{
    try {
        if (!UserExist($pdo, $username)) {
            $stmt = $pdo->prepare('INSERT INTO internal (username, password, renseignementid, permission)
                VALUES (:username, :password, :renseignementid, :permission);');
            return $stmt->execute([
                ':username' => $username,
                ':password' => hash('sha256', $password_unhashed),
                ':renseignementid' => $renseignementid,
                ':permission' => $permission
            ]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function EditUserWithPassword($pdo, $username, $password_unhashed, $renseignementid, $permission)
{
    try {
        if (UserExist($pdo, $username)) {
            $stmt = $pdo->prepare('UPDATE internal SET password=:password,
                renseignementid=:renseignementid, permission=:permission WHERE username=:username;');
            return $stmt->execute([
                ':username' => $username,
                ':password' => hash('sha256', $password_unhashed),
                ':renseignementid' => $renseignementid,
                ':permission' => $permission
            ]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function EditUser($pdo, $username, $renseignementid, $permission)
{
    try {
        if (UserExist($pdo, $username)) {
            $stmt = $pdo->prepare('UPDATE internal SET renseignementid=:renseignementid,
                permission=:permission WHERE username=:username;');
            return $stmt->execute([
                ':username' => $username,
                ':renseignementid' => $renseignementid,
                ':permission' => $permission
            ]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function DeleteUser($pdo, $username)
{
    try {
        if (UserExist($pdo, $username)) {
            $stmt = $pdo->prepare('DELETE FROM internal WHERE username=:username;');
            return $stmt->execute([':username' => $username]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function GetInternalJSON($pdo)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT username, renseignementid, permission FROM internal;');
    $stmt->execute();

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetInternalFromUsernameJSON($pdo, $username)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT username, renseignementid, permission FROM internal WHERE username=:username;');
    $stmt->execute([':username' => $username]);

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}
/* End Internal */

/* Money */
function GetMoney($pdo, $username)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT username, money_perso, money_group, renseignementid FROM internal WHERE username=:username;');
    $stmt->execute([':username' => $username]);

    $usermoney = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usermoney[] = $row;

    $response = [];
    $response['data'] =  $usermoney;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function EditMoneyPerso($pdo, $username, $money_perso)
{
    try {
        if (UserExist($pdo, $username)) {
            $stmt = $pdo->prepare('UPDATE internal SET money_perso=:money_perso WHERE username=:username;');
            return $stmt->execute([
                ':username' => $username,
                ':money_perso' => $money_perso
            ]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function EditMoneyGroup($pdo, $username, $money_group)
{
    try {
        if (UserExist($pdo, $username)) {
            $stmt = $pdo->prepare('UPDATE internal SET money_group=:money_group WHERE username=:username;');
            return $stmt->execute([
                ':username' => $username,
                ':money_group' => $money_group
            ]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function GetMoneyJSON($pdo)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT username, money_perso, money_group, renseignementid FROM internal;');
    $stmt->execute();

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}
/* End Money */

/* Relation */

function CreateRelation($pdo, $name, $behaviour, $strength, $type, $financial_situation, $headcount, $info)
{
    try {
        $stmt = $pdo->prepare('INSERT INTO relation (name, behaviour, strength,
            type, financial_situation, headcount, info)
            VALUES (:name, :behaviour, :strength, :type, :financial_situation,
            :headcount, :info);');
        return $stmt->execute([
            ':name' => $name,
            ':behaviour' => $behaviour,
            ':strength' => $strength,
            ':type' => $type,
            ':financial_situation' => $financial_situation,
            ':headcount' => $headcount,
            ':info' => $info
        ]);
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function RelationExist($pdo, $id)
{
    try {
        $stmt = $pdo->prepare('SELECT id FROM relation WHERE id=:id;');
        $stmt->execute([':id' => $id]);

        $result_array = [];
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
            $result_array[] = $row['id'];

        return count($result_array) > 0;
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function EditRelation($pdo, $id, $name, $behaviour, $strength, $type, $financial_situation, $headcount, $info)
{
    try {
        if (RelationExist($pdo, $id)) {
            $stmt = $pdo->prepare('UPDATE relation SET name=:name, behaviour=:behaviour, strength=:strength,
            type=:type, financial_situation=:financial_situation, headcount=:headcount, info=:info WHERE id=:id;');
            return $stmt->execute([
                ':id' => $id,
                ':name' => $name,
                ':behaviour' => $behaviour,
                ':strength' => $strength,
                ':type' => $type,
                ':financial_situation' => $financial_situation,
                ':headcount' => $headcount,
                ':info' => $info
            ]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function DeleteRelation($pdo, $id)
{
    try {
        if (RelationExist($pdo, $id)) {
            $stmt = $pdo->prepare('DELETE FROM relation WHERE id=:id;');
            return $stmt->execute([':id' => $id]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}


function GetRelationFromIdJSON($pdo, $id)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM relation WHERE id=:id;');
    $stmt->execute([':id' => $id]);

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetRelationDataJSON($pdo)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM relation;');
    $stmt->execute();

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

/* END Relation */

/* Renseignement */
function IdRenseignementExist($pdo, $id)
{
    try {
        $stmt = $pdo->prepare('SELECT id FROM renseignement WHERE id=:id;');
        $stmt->execute([':id' => $id]);

        $result_array = [];
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
            $result_array[] = $row['id'];

        return count($result_array) > 0;
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function CreateRenseignement($pdo, $nickname, $name, $pseudo, $tel,
    $affiliation, $old_affiliation, $position, $license_plate, $known_vehicle,
    $financial_situation, $behaviour, $info, $info_hrp, $dead, $wanted,
    $wanted_since, $fake_nickname, $fake_name, $username)
{
    try {
        $stmt = $pdo->prepare('INSERT INTO renseignement (nickname, name, pseudo, tel,
        affiliation, old_affiliation, position, license_plate, known_vehicle,
        financial_situation, behaviour, info, info_hrp, dead, wanted,
        wanted_since, fake_nickname, fake_name, last_edit_date, last_edit_by) VALUES (:nickname, :name, :pseudo, :tel,
        :affiliation, :old_affiliation, :position, :license_plate, :known_vehicle,
        :financial_situation, :behaviour, :info, :info_hrp, :dead, :wanted,
        :wanted_since, :fake_nickname, :fake_name, :last_edit_date, :last_edit_by);');

        date_default_timezone_set("Europe/Paris");
        return $stmt->execute([
            ':nickname' => $nickname, ':name' => $name,
            ':pseudo' => $pseudo, ':tel' => $tel, ':affiliation' => $affiliation,
            ':old_affiliation' => $old_affiliation, ':position' => $position,
            ':license_plate' => $license_plate, ':known_vehicle' => $known_vehicle,
            ':financial_situation' => $financial_situation, ':behaviour' => $behaviour,
            ':info' => $info, 'info_hrp' => $info_hrp, ':dead' => $dead, ':wanted' => $wanted,
            ':wanted_since' => $wanted_since, ':fake_nickname' => $fake_nickname,
            ':fake_name' => $fake_name, ':last_edit_date' => date('Y-m-d H:i:s'),
            ':last_edit_by' => $username
        ]);
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}


function EditRenseignement($pdo, $id, $nickname, $name, $pseudo, $tel,
    $affiliation, $old_affiliation, $position, $license_plate, $known_vehicle,
    $financial_situation, $behaviour, $info, $info_hrp, $dead, $wanted,
    $wanted_since, $fake_nickname, $fake_name, $username)
{
    if (IdRenseignementExist($pdo, $id)) {
        $stmt = $pdo->prepare('UPDATE renseignement SET nickname=:nickname, name=:name,
            pseudo=:pseudo, tel=:tel, affiliation=:affiliation, old_affiliation=:old_affiliation,
            position=:position, license_plate=:license_plate, known_vehicle=:known_vehicle,
            financial_situation=:financial_situation, behaviour=:behaviour, info=:info, info_hrp=:info_hrp,
            dead=:dead, wanted=:wanted, wanted_since=:wanted_since, fake_nickname=:fake_nickname,
            fake_name=:fake_name, last_edit_date=:last_edit_date, last_edit_by=:last_edit_by WHERE id=:id;');

        date_default_timezone_set("Europe/Paris");
        return $stmt->execute([
            ':nickname' => $nickname, ':name' => $name,
            ':pseudo' => $pseudo, ':tel' => $tel, ':affiliation' => $affiliation,
            ':old_affiliation' => $old_affiliation, ':position' => $position,
            ':license_plate' => $license_plate, ':known_vehicle' => $known_vehicle,
            ':financial_situation' => $financial_situation, ':behaviour' => $behaviour,
            ':info' => $info, 'info_hrp' => $info_hrp, ':dead' => $dead, ':wanted' => $wanted,
            ':wanted_since' => $wanted_since, ':fake_nickname' => $fake_nickname,
            ':fake_name' => $fake_name, ':last_edit_date' => date('Y-m-d H:i:s'),
            ':last_edit_by' => $username, ':id' => $id
        ]);
    } else {
        return false;
    }
}

function DeleteRenseignement($pdo, $id)
{
    try {
        if (IdRenseignementExist($pdo, $id)) {
            $stmt = $pdo->prepare('DELETE FROM renseignement WHERE id=:id;');
            return $stmt->execute([':id' => $id]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function GetRenseignementFromFilterJSON($pdo, $nickname, $name, $pseudo, $tel,
    $affiliation, $old_affiliation, $position, $license_plate, $known_vehicle,
    $financial_situation, $behaviour, $dead, $wanted, $fake_nickname, $fake_name,
    $min_last_edit_date)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    date_default_timezone_set("Europe/Paris");

    $stmt = $pdo->prepare('SELECT id, nickname, name, pseudo, tel, affiliation, financial_situation, behaviour,
        dead, wanted, fake_nickname, fake_name
        FROM renseignement WHERE 
        (nickname LIKE :nickname OR nickname IS NULL) AND (name LIKE :name OR name IS NULL) AND
        (pseudo LIKE :pseudo  OR pseudo IS NULL) AND (tel LIKE :tel OR tel IS NULL) AND 
        (affiliation LIKE :affiliation OR affiliation IS NULL) AND (old_affiliation LIKE :old_affiliation OR old_affiliation IS NULL) AND
        (position LIKE :position OR position IS NULL) AND (license_plate LIKE :license_plate OR license_plate IS NULL) AND
        (known_vehicle LIKE :known_vehicle OR known_vehicle IS NULL) AND (financial_situation LIKE :financial_situation OR financial_situation IS NULL) AND
        (behaviour LIKE :behaviour OR behaviour IS NULL) AND (dead LIKE :dead OR dead IS NULL) AND (wanted LIKE :wanted OR wanted IS NULL) AND
        (fake_nickname LIKE :fake_nickname OR fake_nickname IS NULL) AND (fake_name LIKE :fake_name OR fake_name IS NULL) AND
        (last_edit_date >= :last_edit_date OR last_edit_date IS NULL);');
    
    $stmt->execute([
        ':nickname' => "%$nickname%", ':name' => "%$name%",
        ':pseudo' => "%$pseudo%", ':tel' => "%$tel%", ':affiliation' => "%$affiliation%",
        ':old_affiliation' => "%$old_affiliation%", ':position' => "%$position%",
        ':license_plate' => "%$license_plate%", ':known_vehicle' => "%$known_vehicle%",
        ':financial_situation' => "%$financial_situation%", ':behaviour' => "%$behaviour%",
        ':dead' => "%$dead%", ':wanted' => "%$wanted%", ':fake_nickname' => "%$fake_nickname%",
        ':fake_name' => "%$fake_name%", ':last_edit_date' => "$min_last_edit_date"
    ]);

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetRenseignementFromIdJSON($pdo, $id)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM renseignement WHERE id=:id');
    $stmt->execute([':id' => $id]);

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetRenseignementsJSON($pdo, $full)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    if ($full)
        $sql = 'SELECT * FROM renseignement';
    else
        $sql = 'SELECT id, nickname, name, pseudo,
        tel, affiliation, financial_situation, behaviour,
        dead, wanted, fake_nickname, fake_name FROM renseignement';

    $stmt = $pdo->prepare($sql);
    $stmt->execute();

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}
/* End Renseignement */

/* Stock */
function RessourceTypeExist($pdo, $id)
{
    try {
        $stmt = $pdo->prepare('SELECT id FROM ressource_type WHERE id=:id;');
        $stmt->execute([':id' => $id]);

        $result_array = [];
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
            $result_array[] = $row['id'];

        return count($result_array) > 0;
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function StorageTypeExist($pdo, $id)
{
    try {
        $stmt = $pdo->prepare('SELECT id FROM storage_type WHERE id=:id;');
        $stmt->execute([':id' => $id]);

        $result_array = [];
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
            $result_array[] = $row['id'];

        return count($result_array) > 0;
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function StorageDataExist($pdo, $id)
{
    try {
        $stmt = $pdo->prepare('SELECT id FROM storage_data WHERE id=:id;');
        $stmt->execute([':id' => $id]);

        $result_array = [];
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
            $result_array[] = $row['id'];

        return count($result_array) > 0;
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function StorageExist($pdo, $id)
{
    try {
        $stmt = $pdo->prepare('SELECT id FROM storage WHERE id=:id;');
        $stmt->execute([':id' => $id]);

        $result_array = [];
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
            $result_array[] = $row['id'];

        return count($result_array) > 0;
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function CreateRessourceType($pdo, $name, $mass, $price, $icon)
{
    try {
        $stmt = $pdo->prepare('INSERT INTO ressource_type (name, mass, price, icon)
            VALUES (:name, :mass, :price, :icon);');
        return $stmt->execute([
            ':name' => $name,
            ':mass' => $mass,
            ':price' => $price,
            ':icon' => $icon
        ]);
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function CreateStorageType($pdo, $name, $size)
{
    try {
        $stmt = $pdo->prepare('INSERT INTO storage_type (name, size)
            VALUES (:name, :size);');
        return $stmt->execute([
            ':name' => $name,
            ':size' => $size
        ]);
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function CreateStorageData($pdo, $ressource_type_id, $quantity, $belongto, $storage_id)
{
    try {
        $stmt = $pdo->prepare('INSERT INTO storage_data (ressource_type_id, quantity, belongto, storage_id)
            VALUES (:ressource_type_id, :quantity, :belongto, :storage_id);');
        return $stmt->execute([
            ':ressource_type_id' => $ressource_type_id,
            ':quantity' => $quantity,
            ':belongto' => $belongto,
            ':storage_id' => $storage_id
        ]);
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function CreateStorage($pdo, $owner, $name, $storage_type_id, $location)
{
    try {
        $stmt = $pdo->prepare('INSERT INTO storage (owner, name, storage_type_id, location)
            VALUES (:owner, :name, :storage_type_id, :location);');
        return $stmt->execute([
            ':owner' => $owner,
            ':name' => $name,
            ':storage_type_id' => $storage_type_id,
            ':location' => $location
        ]);
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function EditRessourceType($pdo, $id, $name, $oldname, $mass, $price, $icon)
{
    try {
        if (RessourceTypeExist($pdo, $id)) {
            $stmt = $pdo->prepare('UPDATE ressource_type SET name=:name,
                mass=:mass, price=:price, icon=:icon WHERE id=:id;');
            return $stmt->execute([
                ':name' => $name,
                ':mass' => $mass,
                ':price' => $price,
                ':icon' => $icon,
                ':id' => $id
            ]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function EditStorageType($pdo, $id, $name, $size)
{
    try {
        if (StorageTypeExist($pdo, $id)) {
            $stmt = $pdo->prepare('UPDATE storage_type SET name=:name,
                size=:size WHERE id=:id;');
            return $stmt->execute([
                ':name' => $name,
                ':size' => $size,
                ':id' => $id
            ]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function EditStorageData($pdo, $id, $ressource_type_id, $quantity, $belongto, $storage_id)
{
    try {
        if (StorageDataExist($pdo, $id)) {
            $stmt = $pdo->prepare('UPDATE storage_data SET ressource_type_id=:ressource_type_id,
                quantity=:quantity, belongto=:belongto, storage_id=:storage_id WHERE id=:id;');
            return $stmt->execute([
                ':ressource_type_id' => $ressource_type_id,
                ':quantity' => $quantity,
                ':belongto' => $belongto,
                ':storage_id' => $storage_id,
                ':id' => $id
            ]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function EditStorage($pdo, $id, $owner, $name, $storage_type, $location)
{
    try {
        if (StorageExist($pdo, $id)) {
            $stmt = $pdo->prepare('UPDATE storage SET owner=:owner,
                name=:name, storage_type=:storage_type, location=:location WHERE id=:id;');
            return $stmt->execute([
                ':owner' => $owner,
                ':name' => $name,
                ':storage_type' => $storage_type,
                ':location' => $location,
                ':id' => $id
            ]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function DeleteRessourceType($pdo, $id)
{
    try {
        if (RessourceTypeExist($pdo, $id)) {
            $stmt = $pdo->prepare('DELETE FROM ressource_type WHERE id=:id;');
            return $stmt->execute([':id' => $id]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function DeleteStorageType($pdo, $id)
{
    try {
        if (StorageTypeExist($pdo, $id)) {
            $stmt = $pdo->prepare('DELETE FROM storage_type WHERE id=:id;');
            return $stmt->execute([':id' => $id]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function DeleteStorageData($pdo, $id)
{
    try {
        if (StorageDataExist($pdo, $id)) {
            $stmt = $pdo->prepare('DELETE FROM storage_data WHERE id=:id;');
            return $stmt->execute([':id' => $id]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function TryDeleteStorageDataFromStorageID($pdo, $id)
{
    try {
        $stmt = $pdo->prepare('DELETE FROM storage_data WHERE storage_id=:id;');
        $stmt->execute([':id' => $id]);
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}


function DeleteStorage($pdo, $id)
{
    try {
        if (StorageExist($pdo, $id)) {
            TryDeleteStorageDataFromStorageID($pdo, $id);
            $stmt = $pdo->prepare('DELETE FROM storage WHERE id=:id;');
            return $stmt->execute([':id' => $id]);
        } else {
            return false;
        }
    } catch (Exception $e) {
        echo 'Database error : ' . $e->getMessage();
    }
}

function GetRessourceTypeJSON($pdo)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM ressource_type;');
    $stmt->execute();

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetRessourceTypeFromIdJSON($pdo, $id)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM ressource_type WHERE id=:id;');
    $stmt->execute([':id' => $id]);

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetStorageTypeJSON($pdo)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM storage_type;');
    $stmt->execute();

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetStorageTypeFromIdJSON($pdo, $id)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM storage_type WHERE id=:id;');
    $stmt->execute([':id' => $id]);

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetStorageJSON($pdo)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM storage;');
    $stmt->execute();

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetStorageFromIdJSON($pdo, $id)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM storage WHERE id=:id;');
    $stmt->execute([':id' => $id]);

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetStorageDataJSON($pdo)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM storage_data;');
    $stmt->execute();

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetStorageDataFromIdJSON($pdo, $id)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM storage_data WHERE id=:id;');
    $stmt->execute([':id' => $id]);

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}

function GetStorageDataFromStorageIdJSON($pdo, $storage_id)
{
    // Will format everything in json be careful
    header("Content-Type:application/json");

    $stmt = $pdo->prepare('SELECT * FROM storage_data WHERE storage_id=:storage_id;');
    $stmt->execute([':storage_id' => $storage_id]);

    $usersinfo = [];
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        $usersinfo[] = $row;

    $response = [];
    $response['data'] =  $usersinfo;

    echo json_encode($response, JSON_PRETTY_PRINT);
}
/* End Stock */

/* Admin */
function CreateGroup($pdo, $group, $username, $password_unhashed)
{
    $result = 0;

    $stmt = $pdo->prepare('CREATE DATABASE :databasename;');
    $result += $stmt->execute([':databasename' => $group]);

    $stmt = $pdo->prepare('CREATE TABLE internal ( 
        username VARCHAR(100) NULL, 
        password VARCHAR(64) NULL, 
        money_perso INT NOT NULL DEFAULT 0,
        money_group INT NOT NULL DEFAULT 0,
        renseignementid INT NOT NULL DEFAULT -1, 
        permission VARCHAR(20) NULL
    );');
    $result += $stmt->execute();

    $stmt = $pdo->prepare('CREATE TABLE relation ( 
        id SERIAL,
        name VARCHAR(100) NULL, 
        behaviour VARCHAR(50) NULL, 
        strength VARCHAR(50) NULL,
        type VARCHAR(50) NULL,
        financial_situation VARCHAR(50) NULL,
        headcount INT NOT NULL DEFAULT 0, 
        info VARCHAR(2000) NULL
    );');
    $result += $stmt->execute();

    $stmt = $pdo->prepare('CREATE TABLE ressource_type ( 
        id SERIAL,
        name VARCHAR(100) NULL, 
        mass INT NOT NULL DEFAULT 0, 
        price INT NOT NULL DEFAULT 0, 
        icon BLOB NULL
    );');
    $result += $stmt->execute();

    $stmt = $pdo->prepare('CREATE TABLE storage_type ( 
        id SERIAL,
        name VARCHAR(100) NULL, 
        size INT NOT NULL DEFAULT 0
    );');
    $result += $stmt->execute();

    $stmt = $pdo->prepare('CREATE TABLE storage_data ( 
        id SERIAL,
        ressource_type_id INT NOT NULL DEFAULT -1,
        quantity INT NOT NULL DEFAULT 0, 
        belongto VARCHAR(100) NULL,
        storage_id INT NOT NULL DEFAULT -1);');
    $result += $stmt->execute();

    $stmt = $pdo->prepare('CREATE TABLE storage ( 
        id SERIAL,
        owner VARCHAR(100) NULL,
        name VARCHAR(100) NULL, 
        storage_type_id INT NOT NULL DEFAULT -1, 
        location VARCHAR(100) NULL);');
    $result += $stmt->execute();
    
    $stmt = $pdo->prepare('CREATE TABLE renseignement ( 
        id SERIAL,
        nickname VARCHAR(100) NULL, 
        name VARCHAR(100) NULL, 
        pseudo VARCHAR(100) NULL, 
        tel VARCHAR(6) NULL, 
        affiliation VARCHAR(1000) NULL, 
        old_affiliation VARCHAR(1000) NULL, 
        position VARCHAR(1000) NULL, 
        license_plate VARCHAR(1000) NULL, 
        known_vehicle VARCHAR(1000) NULL, 
        financial_situation VARCHAR(50) NULL, 
        behaviour VARCHAR(50) NULL,
        info VARCHAR(2000) NULL, 
        info_hrp VARCHAR(2000) NULL, 
        dead TINYINT(1) NOT NULL DEFAULT 0, 
        wanted TINYINT(1) NOT NULL DEFAULT 0, 
        wanted_since DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP, 
        fake_nickname VARCHAR(100) NULL, 
        fake_name VARCHAR(100) NULL, 
        last_edit_date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
        last_edit_by VARCHAR(100) DEFAULT "?"
       );');
    $result += $stmt->execute();

    $result += CreateUser($pdo, $username, $password_unhashed, -1, 'max');

    return $result == 3;
}
/* End Admin */

?>