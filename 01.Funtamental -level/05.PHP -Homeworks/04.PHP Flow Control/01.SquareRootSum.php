<!doctype html>
<?php
$counter = 0;
for ($i = 0; $i <= 100; $i+=2) {
    $numb[]= $i;

}
$sum=0;
for ($i = 0; $i <count($numb); $i++) {
    $sqrRoot[$i] =number_format(sqrt($numb[$i]),2)+0;
    $sum+=$sqrRoot[$i];
}
?>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Square Root</title>
</head>
<body>
    <table border="1">
        <tr style="font-weight: bold">
            <td>Number</td>
            <td>Square</td>
        </tr>
        <?php
            for ($i = 0; $i < count($numb); $i++) {
        ?><tr>
                    <td><?=$numb[$i] ?></td>
                    <td><?=$sqrRoot[$i]?></td>
                </tr>
            <?php } ?>
        <tr>
            <td style="font-weight: bold">Total</td>
            <td><?= $sum ?></td>
        </tr>
    </table>
</body>
</html>