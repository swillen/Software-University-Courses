function findMaxSequence(value) {
    var maxCounter = 1;
    var counter = 1;
    var maxValue = "";
    var prevMaxCounter = 1;
    var returnArray = new Array();
    if (value.length == 1) {
        returnArray[0] = value[0];
        return console.log(returnArray);
    }
    for (var i = 0; i < value.length - 1; i++) {
        if (value[i] === value[i + 1]) {
            counter++;
            if (counter >= maxCounter) {
                maxCounter = counter;
                maxValue = value[i];
            }
        } else {
            counter = 1;
        }
    }
    for (i = 0; i < maxCounter; i++) {
        returnArray[i] = maxValue;

    }
    return console.log(returnArray);
}
findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);
findMaxSequence(['happy']);
findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']);
findMaxSequence([2, 2, 5, 3, 1, 7]);