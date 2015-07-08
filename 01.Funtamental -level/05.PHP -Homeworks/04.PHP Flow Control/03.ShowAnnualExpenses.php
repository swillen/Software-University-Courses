<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Show Annual Expenses</title>
</head>
    <body>
        <form action="" method="post">
            <label for="years">Enter number of years</label>
            <input type="text" name="numbYears" id="years"/>
            <input type="submit" value="Show costs"/>
        </form>
    </body>
</html>
<?php
    if(isset($_POST['numbYears'])){
        $numbOfYears = $_POST['numbYears'];
        $currentYear = date("Y");
?>
            <?php
            $sum = 0;
            echo "<table border='1'>";
            echo "<tr style='font-weight: bold' >
                    <td>Year</td>
                    <td>January</td>
                    <td>February</td>
                    <td>March</td>
                    <td>April</td>
                    <td>May</td>
                    <td>June</td>
                    <td>July</td>
                    <td>August</td>
                    <td>September</td>
                    <td>October</td>
                    <td>November</td>
                    <td>December</td>
                    <td>Total:</td>
                </tr>";
            for ($i = $currentYear; $i > $currentYear-$numbOfYears; $i--) {
                echo "<tr>";
                echo "<td>$i</td>";
                for ($j = 0; $j <12; $j++) {
                    $monthExp = mt_rand(0,999);
                    $sum +=$monthExp;
                    echo "<td>$monthExp</td>";
                }
                 echo "<td>$sum </td>";
                echo "</tr>";
            }
            echo "</table>";
            ?>

 <?php } ?>


