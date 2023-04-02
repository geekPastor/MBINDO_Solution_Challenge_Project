<?php

    class Autoloader{
        
        /**
         * register
         *
         * @return void
         */
        static function register()
        {
            spl_autoload_register(function($class)
            {

                require '_classes/'.$class.'.php';
                
            });
        }
    }
