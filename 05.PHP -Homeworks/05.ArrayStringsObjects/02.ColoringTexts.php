<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Coloring Texts</title>
</head>
<body>
<form action="" method="get">
    <textarea name="text"  cols="30" rows="5"></textarea><br/>
    <input type="submit" value="Color Text"/>
</form>
</body>
</html>
<?php
if(isset($_GET['text'])) {
    $input = $_GET['text'];
    $input = explode(" ", $input);
    $splited = implode("", $input);
    $result = str_split($splited);
    foreach ($result as $value) {
        if (ord($value) % 2 == 0) {
            echo "<span style='color: red'>$value </span>";
        } else {
            echo "<span style='color: blue'>$value </span>";
        }

    }
}
?>