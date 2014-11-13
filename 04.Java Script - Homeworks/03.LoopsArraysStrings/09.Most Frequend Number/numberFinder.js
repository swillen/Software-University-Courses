function findMostFreqNum(value) {
    var counter = 1;
    var maxCounter = 1;
    var maxValue = 0;
    var arrayCounter = new Array();
    for (var i = 0; i < value.length; i++) {
        for (var j = i + 1; j < value.length; j++) {
            if (value[i] == value[j]) {
                counter++;
            }
        }
        if (counter >= maxCounter) {
            maxCounter = counter;
            maxValue = value[i];
        }
        counter = 1;
        arrayCounter.push(maxValue);
    }
    if (maxCounter == 1) {
        console.log(arrayCounter[0]+" ("+maxCounter+" times )");
    } else {
        console.log(maxValue + " (" + maxCounter + " times )");
    }
}
findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]);
findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]);
