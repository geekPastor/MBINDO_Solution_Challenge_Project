<?php

    /**
     * str_secure
     *
     * @param  mixed $var
     * @return void
     */
    
    function str_secure(string $var)
    {
        return trim(htmlspecialchars($var));
    }

    /**
     * debug
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
