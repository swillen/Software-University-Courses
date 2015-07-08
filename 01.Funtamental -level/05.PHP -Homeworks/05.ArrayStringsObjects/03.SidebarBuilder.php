<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Sidebar Builder</title>
    <style>
        input{
            margin-bottom: 10px;
        }
        div{
            margin-bottom: 10px;
            width: 150px;
            padding: 5px;
            background-color: lightblue;
            padding-left: 50px;

        }
        div>h3{
            text-decoration: underline;
        }

    </style>
</head>
<body>
<form action="" method="get">
    <label for="categories">Categories: </label>
    <input type="text" id="categories" name="categories"/><br/>
    <label for="tags">Tags: </label>
    <input type="text" id="tags" name="tags"/><br/>
    <label for="months">Months: </label>
    <input type="text" name="months" id="months"/><br/>
    <input type="submit" value="Generate"/>
</form>
</body>
</html>
<?php
if(isset($_GET['categories'],$_GET['tags'],$_GET['months'])){
    $cat = explode(", ",$_GET['categories']);
    $tags = explode(", ",$_GET['tags']);
    $months = explode(", ",$_GET['months']);?>

        <div style="border: 1px solid black;border-radius: 5px">
            <h3>Categories</h3>
            <ul style="list-style-type: circle">
                <?php foreach($cat as $value){
                    echo "<li>$value</li>";
                }    ?>
            </ul>
        </div>

        <div style="border: 1px solid black;border-radius: 5px">
            <h3>Tags</h3>
            <ul style="list-style-type: circle">
                <?php foreach($tags as $value){
                    echo "<li>$value</li>";
                }    ?>
            </ul>
        </div>

        <div style="border: 1px solid black;border-radius: 5px">
            <h3>Months</h3>
            <ul style="list-style-type: circle">
                <?php foreach($months as $value){
                    echo "<li>$value</li>";
                }    ?>
            </ul>
        </div>

<?php } ?>



