<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Modify String</title>
</head>
<body>
<form action="" method="get">
    <input type="text" name="string" />
    <input type="radio" name="operation" id="palindrome" value="palindrome"/><label for="palindrome">Check Palindrome</label>
    <input type="radio" name="operation" id="reverse" value="reverse"/><label for="reverse">Reverse String</label>
    <input type="radio" name="operation" id="split" value="split"/><label for="split">Split</label>
    <input type="radio" name="operation" id="hash" value="hash"/><label for="hash">Hash String</label>
    <input type="radio" name="operation" id="shuffle" value="shuffle"/><label for="shuffle">Shuffle String</label>
    <input type="submit" value="Submit"/>
</form>
</body>
</html>
<?php
if(isset($_GET['string'],$_GET['operation'])){
    $string = $_GET['string'];
    $operation = $_GET['operation'];
    if($operation=="palindrome" ){
        if($string==strrev($string) ){
            echo "\"".$string."\""." is  a palindrome!";
        }else{
            echo "\"".$string."\""." is not a palindrome!";
        }
    }elseif($operation=="reverse"){
        echo strrev($string);
    }elseif($operation=="split"){
        $arr= str_split($string);
        foreach($arr as $value){
            echo $value." ";
        }
    }elseif($operation=="hash"){
        echo crypt('str',$string);
    }elseif($operation=="shuffle"){
        $arrShuffle =str_split($string);
        $implSh = implode("",$arrShuffle);
        echo str_shuffle($implSh);
    }

}

?>