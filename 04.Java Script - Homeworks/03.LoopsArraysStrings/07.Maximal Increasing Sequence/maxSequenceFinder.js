function findMaxSequence(value) {
    var counter = 1;
    var maxCounter = 1;
    var arrayValues = new Array();
    var startPlace = 0;
    var endPlace = 0;
    for (var i = 0; i < value.length - 1; i++) {
        if (value[i] < value[i + 1]) {
            counter++;
            if (counter > maxCounter) {
                maxCounter = counter;
                endPlace = i + 1;
                startPlace = endPlace - (maxCounter - 1);
            }
        } else {
            counter = 1;
        }
    }
    if (maxCounter == 1 || value.length == 1) {
        return console.log("no");
    } else {
        for (i = startPlace, c = 0; i <= endPlace, c < maxCounter; i++, c++) {
            arrayValues[c] = value[i];
        }
        return console.log(arrayValues);
    }
}
findMaxSequence([3, 2, 3, 4, 2, 2, 4]);
findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);
findMaxSequence([2, 2]);
findMaxSequence([3, 2, 1]);