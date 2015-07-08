<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Find Primes in range</title>
</head>
    <body>
        <form action="" method="get">
            <label for="start">Starting Index: </label>
            <input type="text" name="start" id="start"/>
            <label for="end" style="margin-left: 10px">End: </label>
            <input type="text" name="end" id="end"/>
            <input type="submit" value="Submit"/>

        </form>
    </body>
</html>
<?php
function isPrime($number){
    $checker = false;
    if($number==1 || $number==0){
        $checker=false;
    }elseif($number==2 || $number==3){
        $checker=true;
    }else {
        for ($i = 2; $i <= (int)sqrt($number); $i++) {
            if ($number % $i == 0 && $i != $number) {
                $checker = false;
                break;
            } else {
                $checker = true;
            }
        }
    }
    if($checker){
        return "<span style='font-weight: bold'>$number</span>";
    }else{
        return "<span>$number</span> ";
    }
}
if(isset($_GET['start'],$_GET['end'])){
    $startIndex = $_GET['start'];
    $endIndex = $_GET['end'];
    if(is_numeric($startIndex) && is_numeric($endIndex) && $endIndex>$startIndex) {

        for ($i = $startIndex; $i <= $endIndex; $i++) {
            if($i==$endIndex){
                echo isPrime($i);
            }else {
                echo isPrime($i).", ";
            }
        }

    }else{
        die('Please enter valid numbers!');
    }
}
?>