<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Text Filter</title>
</head>
<body>
<form action="" method="get">
    <textarea name="text" ></textarea><br/>
    <label for="banlist">Banlist: </label>
    <input type="text" name="banlist" id="banlist"/><br/>
    <input type="submit" value="Submit"/>
</form>

</body>
</html>
<?php
if(isset($_GET['text'],$_GET['banlist'])){
    $text = $_GET['text'];
    $banlist = explode(", ",$_GET['banlist']);

    echo"<br>";
    for ($i = 0; $i <count($banlist); $i++) {
        $searched = $banlist[$i];
        $replacement = str_repeat("*",strlen($searched));
        $result = str_replace($searched,$replacement,$text);
        $text=$result;
    }
    echo $result;
}






?>