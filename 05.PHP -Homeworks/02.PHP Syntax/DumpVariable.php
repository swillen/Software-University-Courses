<?php

$var = (object)[2,34];
if(gettype($var)=="integer" || gettype($var)=="double"){
    var_dump($var);
}
else{
    echo gettype($var);
}

?>