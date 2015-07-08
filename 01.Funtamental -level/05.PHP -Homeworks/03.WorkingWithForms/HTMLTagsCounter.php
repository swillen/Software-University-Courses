<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
    <style >
        body{
            margin:20px;
        }
        label{
            display:block;
            margin-bottom: 10px;
        }
        p{
            font-weight: bolder;
            font-size: 20px;
        }
    </style>
</head>
<body>
<form action="" method="get">
    <label for="tg">Enter HTML tags:</label>
    <input type="text" name="tags" id="tg" >
    <input type="submit" >
</form>
</body>
</html>

<?php
session_start();
$tags = ["!DOCTYPE","a","abbr","acronym","address","applet","area","article","aside","audio","b","base","basefont","bdi",
    "bdo","big","blockquote","body","br","button","canvas","caption","center","cite","code","col","colgroup","datalist","dd",
    "del","details","dfn","dialog","dir","div","dl","dt","em","embed","fieldset","figcaption","figure","font","footer","form",
    "frame","frameset","h1", "h2","h3","h4","h5", "h6","head","header","hgroup","hr","html","i","iframe","img","input","ins",
    "kbd","keygen","label","legend","li","link","main","map","mark","menu","menuitem","meta","meter","nav","noframes","noscript",
    "object","ol","optgroup","option","output","p","param","pre","progress","q","rp","rt","ruby","s","samp","script","section",
    "select","small","source","span","strike","strong","style","sub","summary","sup","table","tbody","td","textarea","tfoot","th",
    "thead","time","title","tr","track","tt","u","ul","var","video","wbr"];
if(isset($_GET['tags'])){
    $tag = $_GET['tags'];
    if(in_array($tag,$tags)){
        if(isset($_SESSION['count'])){
            $_SESSION['count']++;
            echo "<p>Valid HTML tag!</p>";
            echo "<p>Score:".$_SESSION['count']."</p>";
        }
    }else{
        echo "<p>Invalid HTML tag</p>";
    }
}else{
    session_destroy();
}
?>