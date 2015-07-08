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
    <style>
        table,td{
            width:300px;
            height:30px;
        }
        td:first-child{
            background-color:#FE9C03;
            font-weight:bold;
            padding-left:5px;

        }
        td:last-child{
            text-align:right;
            padding-right:10px;
        }
        table,td{
            border:1px solid black;
            border-style:groove;
        }

    </style>
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
