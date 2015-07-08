<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Word Mapping</title>
</head>
<body>
<form action="" method="get">
    <textarea name="text" id="" cols="30" rows="10"></textarea><br/>
    <input type="submit" value="Count words"/>
</form>
</body>
</html>
<?php
if(isset($_GET['text'])) {

    $inp = $_GET['text'];
    $inp = strtolower($inp);
    $arr = preg_split("/[\W]+/", $inp, -1, PREG_SPLIT_NO_EMPTY);

    $res = [];
    $res = array_count_values($arr);
    echo "<table border='1'>";
    foreach ($res as $key => $value) {
        echo "<tr>";
        echo "<td>{$key}</td>";
        echo "<td style='width: 20px'>{$value}</td>";
        echo "</tr>";
    }
    echo "</table>";
}