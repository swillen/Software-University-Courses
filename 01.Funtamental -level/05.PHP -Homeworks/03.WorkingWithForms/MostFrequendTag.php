<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
<p>Enter Tags:</p>
<form action="" method="post">
    <input type="text" name="tags"  placeholder="">
    <input type="submit" name="submit" value="Submit">
</form>
</body>
</html>
<?php
if(isset($_POST['tags'])) {
    $variables = $_POST['tags'];
    $arr = explode(",",$variables);
    $count = array_count_values($arr);
    arsort($count);
    foreach ($count as $key => $val) {
        echo "$key : $val times <br>";
    }
    echo "<br>The most Frequent Tag is: " . array_keys($count)[0];
}
?>


<!--//$counter = 1;
//$counters =[];
//if(isset($_POST['tags'])) {
//    $variables = $_POST['tags'];
//    $varArr = explode(", ", $variables);
//
//    for ($i = 0; $i < count($varArr); $i++) {
//        for ($j = 0; $j < count($varArr); $j++) {
//            if (isset($varArr[$i]) && isset($varArr[$j]) && $varArr[$i] == $varArr[$j] && $j != $i) {
//                $counter++;
//                unset($varArr[$j]);
//
//            }
//        }
//        $counters[$i] = $counter;
//        $counter = 1;
//    }
//
//    $result = [];
//    $i = 0;
//    foreach ($varArr as $value) {
//        $result[$value] = $counters[$i];
//        $i++;
//    }
//    arsort($result);
//    foreach ($result as $key => $val) {
//        echo "$key :$val times <br>\n";
//    }
//    echo "<br> Most Frequent Tag is: " . array_keys($result)[0];
//}-->

