<?php

    /**
     * str_secure nous aide a securiser une chaine venant d'un utilisateur quelconque
     *
     * @param  mixed $var
     * @return void
     */
    
    function str_secure(string $var)
    {
        return trim(htmlspecialchars($var));
    }

    /**
     * debug Dans notre etape de developpement vas nous aider a comprendre le flux de donnees dans notre projet
     *
     * @param  mixed $var
     * @return void
     */
    function debug($var): void
    {
        echo '<pre>';
            var_dump($var);
        echo '</pre>';
    }
