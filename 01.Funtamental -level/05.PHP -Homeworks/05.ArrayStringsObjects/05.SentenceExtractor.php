<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
<form action="" method="get">
    <input type="text" name="text"/>
    <input type="text" name="word"/>
    <input type="submit"  value="Extract"/>
</form>
</body>
</html>
<?php
if(isset($_GET['text'],$_GET['word'])) {
    $word =$_GET['word'];
    $patern = '/[^.!?]+[.!?]*/';
    $text = $_GET['text'];
    preg_match_all($patern, $text, $sentences);
    $searched = "/[^\w]" . $word . "[^\w]/";
    foreach ($sentences[0] as $value) {
        $value = trim($value);
        if (preg_match($searched,$value)) {
            echo "$value <br/>\n";
        }
    }

}
?>