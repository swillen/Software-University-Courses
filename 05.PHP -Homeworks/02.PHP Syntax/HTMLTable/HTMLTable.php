<?php
$name  = 'Gosho';
$number ='0882-321-423';
$age = '24';
$adress = "Hadji Dimitar";
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
    <link rel="stylesheet" href="style.css"/>
</head>
<body>
<table cellspacing="0">
    <tr>
        <td>Name </td>
        <td><?php echo $name ?></td>
    </tr>
    <tr>
        <td>Phone Number</td>
        <td><?php echo $number ?></td>
    </tr>
    <tr>
        <td>Age</td>
        <td><?php echo $age ?></td>
    </tr>
    <tr>
        <td>Adress</td>
        <td> <?php echo $adress?> </td>
    </tr>
</table>
</body>
</html>
