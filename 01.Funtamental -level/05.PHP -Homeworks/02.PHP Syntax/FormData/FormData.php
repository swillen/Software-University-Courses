<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
    <link rel="stylesheet" href="style.css"/>
</head>
<body>
<form  method="get">

    <input type="text" name="name"  >

    <input type="text" name="age" >
    <input type="radio" name="gender" id="male" value="male"><label for="male">Male</label>

    <input type="radio" name="gender" id="female" value="female"><label for="female">Female</label>
    <input type="submit" name="submit" value="Submit">
</form>
<?php
if(isset($_GET["name"])&& isset($_GET["age"]) && isset($_GET["gender"])){
    echo "My name is $_GET[name].I am $_GET[age] years old.I am $_GET[gender].";
}


?>

</body>
</html>
