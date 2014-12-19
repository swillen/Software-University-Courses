<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
    <style >
        div{
            margin:10px;
            margin-left: 15px;
        }

    </style>
</head>
<body>
<form action="" method="get">
    <div>Enter Amount <input type="text" name="amount" ></div>
    <div>
        <input type="radio" name="currency" value="$" id="usd" ><label for="usd">USD</label>
        <input type="radio" name="currency" value="€" id="eur"><label for="eur">EUR</label>
        <input type="radio" name="currency" value="BGN" id="bgn" ><label for="bgn">BGN</label>
    </div>
    <div>Compount Interest Amount <input type="text" name="cia" ></div>
    <div>
        <select name="months" >
            <option value="6">6 Months</option>
            <option value="1">1 Year</option>}
            <option value="2">2 Years</option>}
            <option value="5">5 Years</option>}
        </select>
        <input type="submit" name="" value="Calculate">
    </div>
</form>

</body>
</html>
<?php
if( isset($_GET['amount']) && isset($_GET['currency']) && isset($_GET['cia']) && isset($_GET['months'])){

    $currValue = $_GET['amount'];
    $cia = $_GET['cia'];
    $result = 0;
    $interest = 100+(double)$cia/12;
    $time = $_GET['months'];
    for ($i = 0; $i <$time; $i++) {
        $result=$currValue*($interest/100);
        $currValue=$result;
    }
    $result= number_format($result,2,'.','');
    $currency = $_GET['currency'];
    $result = $currency." ".$result;
    echo "<p>$result</p>";
}


?>