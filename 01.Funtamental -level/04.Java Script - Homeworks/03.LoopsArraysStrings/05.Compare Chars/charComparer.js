function compareChars(value) {
    var checker = false;
    var loopLenght = value[0].length;
    for (var i = 0; i < loopLenght - 1; i++) {
        if (value[0][i] == value[1][i]) {
            checker = true;
        } else {
            checker = false;
            break;
        }
    }
    if (checker) {
        console.log("Equal");
    } else {
        console.log("Not Equal");
    }
}
compareChars([
    ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'],
    ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']
]);
compareChars([
    ['3', '5', 'g', 'd'],
    ['5', '3', 'g', 'd']
]);
compareChars([
    ['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'],
    ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']
]);