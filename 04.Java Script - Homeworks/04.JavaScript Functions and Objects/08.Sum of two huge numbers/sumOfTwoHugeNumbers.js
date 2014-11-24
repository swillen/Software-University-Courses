function sumTwoHugeNumbers(value) {
    var a = value[0];
    var b = value[1];
    var fillWithZeroesToLeft = new Array();
    var fillWithZeroesToRight = new Array();
    var number = new Array();
    var difference = 0;
    //makes the numbers with equal lenght by filling it with 0
    if (a.length > b.length) {
        difference = a.length - b.length;
        for (var i = 0; i < difference; i++) {
            fillWithZeroesToLeft.push(0);
        }
        b = fillWithZeroesToLeft + b;
    } else if (b.length > a.length) {
        difference = b.length - a.length;
        for (var i = 0; i < difference; i++) {
            fillWithZeroesToRight.push(0);
        }
        a =fillWithZeroesToRight+a;
    }
    //sum the last digits
    var sum = 0;
    for (var i = a.length-1; i >= 0; i--) {
        
        for (var j = i; j >= 0; j--) {
            sum += parseInt(a[i]) + parseInt(b[j]);
            if (sum > 9) {
                number.push(sum.toString()[sum.toString().length - 1]);
                break;
            } else if (sum < 10) {
                number.push(sum.toString());
                break;
            }

        }
        if (sum > 9) {
            sum = 1;
        } else {
            sum = 0;
        }

    }
    console.log(number.reverse().join(""));
}
sumTwoHugeNumbers(['155', '65']);
sumTwoHugeNumbers(['123456789', '123456789']);
sumTwoHugeNumbers(['887987345974539', '4582796427862587']);
sumTwoHugeNumbers(['347135713985789531798031509832579382573195807',
 '817651358763158761358796358971685973163314321']
);


