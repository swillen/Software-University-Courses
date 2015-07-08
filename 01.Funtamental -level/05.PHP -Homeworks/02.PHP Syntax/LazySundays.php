<?php
$timestamp=strtotime('2014-12');

$firstD = date('01', $timestamp);
$lastD  = date('t', $timestamp);
$endInt = (int)$lastD;
$startInt = (int)$firstD;
$currMonth = date('F',$timestamp);
$currYear = date('Y',$timestamp);
for ($i = $startInt; $i <=$endInt; $i++) {
    $currDate = "2014-12-$i ";
    $currDay = date('l',strtotime($currDate));
    if($currDay=="Sunday"){
        echo "$i-th $currMonth ,$currYear \n";
    }
}
?>