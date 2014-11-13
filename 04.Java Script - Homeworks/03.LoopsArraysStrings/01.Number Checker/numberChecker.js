function printNumbers(n) {
    var check = false;
    var numbers = [];
    for (var i = 0; i <= n; i++) {
        if (i % 4 == 0 || i % 5 == 0) {
            continue;
        } else {
            numbers.push(i);
            check = true;
        }
    }
    if (check==false) {
        console.log("no");
    }else{
    	console.log(numbers.join());
    }
}
printNumbers(20);
printNumbers(-5);
printNumbers(13);