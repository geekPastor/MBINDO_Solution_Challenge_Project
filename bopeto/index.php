<?php
    //Porte d'entree de notre bopeto

    include_once '_classes/Autoloader.php';

    Autoloader::register();

    //Definition de la page courante

    if (isset($_GET['page']) AND !empty($_GET['page'])) {

        //On assigne dans une variable le nom de la page

        $page = strtolower(trim(htmlspecialchars($_GET['page'])));

    } else {

        $page = 'home';

    }

    //Array contenant toute les pages

    $allPages = scandir('controllers/');

    if (in_array($page.'_controller.php', $allPages)) {

        //Inclusion de la page

        include_once 'models/'.$page.'_model.php';
        include_once 'controllers/'.$page.'_controller.php';
        include_once 'views/'.$page.'_view.php';

    } else {

        //Retourner erreur

        echo 'Ereur 404 ';
        
    }
    
