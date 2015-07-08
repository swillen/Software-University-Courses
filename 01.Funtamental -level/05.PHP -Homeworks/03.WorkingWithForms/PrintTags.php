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

if(isset($_POST['tags'])){
    $variables = $_POST['tags'];
    $varArr = explode(", ",$variables);
    for ($i = 0; $i <count($varArr); $i++) {
        echo "$i : $varArr[$i]<br>";

    }
}
?>