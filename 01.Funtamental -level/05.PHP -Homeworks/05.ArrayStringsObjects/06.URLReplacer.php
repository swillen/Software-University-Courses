<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
<form action="" method="get">
    <textarea name="text" ></textarea>
    <input type="submit" name="Submit"/>
</form>
</body>
</html>
<?php
if(isset($_GET['text'])) {
$text = $_GET['text'];

    $result = preg_replace("/(<a\s+?href=)/", "[URL=", $text);
    $result = preg_replace("/\\\"(\>)/", "] ", $result);
    $result = preg_replace("/\<\/a\>/", "[/URL]", $result);

    echo htmlentities($result);
}