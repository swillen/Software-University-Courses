<?php

$number = 247;
$arr= array();

if($number<102 ){
    echo "no";
}
else{
    for ($i = 102; $i <=$number; $i++) {
        $strNumb = (string)$i;
        for ($j = 0; $j < strlen($strNumb); $j++) {
            if($strNumb[0] !==$strNumb[1] && $strNumb[1]!==$strNumb[2] && $strNumb[0]!==$strNumb[2] && strlen($strNumb)<4 ){
                array_push($arr,$strNumb);
                break;
            }
        }
    }
}
//foreach($arr as $value){
//    echo $value.", ";
//}
echo implode($arr,", ");
?>