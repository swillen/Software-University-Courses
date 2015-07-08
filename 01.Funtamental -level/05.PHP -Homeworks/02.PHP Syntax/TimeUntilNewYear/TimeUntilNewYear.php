<?php
date_default_timezone_set('Europe/Sofia');
$date1 = new DateTime();
$formatt = $date1->format('Y-m-d h:i:s');
$date2 = "2015-01-01 00:00:00";
$diff=strtotime($date2)-strtotime($formatt);


$hourRemain = floor($diff/3600);
$minutesRemain = ($diff/60)%60;
$secondsRemain = $diff%60;
$daysRemain = floor($hourRemain/24);

$hRem =$hourRemain- $daysRemain*24;

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Time Until New Year</title>
    <link rel="stylesheet" href="style.css"/>
</head>
<body>
<div>
    <p>ВЕСЕЛИ ПРАЗНИЦИ </p>
    <p> Days until new year:<?php echo $daysRemain ?> </p>
    <p> Hours until new year: <?php echo $hourRemain ?> </p>
    <p> Minutes until new year:<?php echo floor($diff/60) ?> </p>
    <p> Seconds until new year:<?php echo $diff ?> </p>
    <p><?php echo "$daysRemain days $hRem hours $minutesRemain minutes and $secondsRemain seconds"?></p>
</div>


</body>
</html>