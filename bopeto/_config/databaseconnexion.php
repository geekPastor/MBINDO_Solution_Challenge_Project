<?php

    try {

        $database = new PDO('myslql:host=localhost, dbname=bopeto', 'root', '');

    } catch (Exception $e) {

        die('Error connexion : '.$e->getMessage());
    
    }
    