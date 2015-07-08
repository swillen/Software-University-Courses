function biggerThanNeighbors(index, arr) {
    if (index == 0 || index == arr.length - 1) {
        return "only one neighbor";
    } else if (index < 0 || index > arr.length - 1) {
        return "invalid index";
    } else if (index > 0 && index < arr.length - 1) {
        if (arr[index] > arr[index + 1] && arr[index] > arr[index - 1]) {
            return "bigger";
        } else {
            return "not bigger";
        }

    }
}
function printResult(index, arr) {
    var print = biggerThanNeighbors(index, arr);
    if (print == "only one neighbor") {
        console.log("only one neighbor");
    }
    else if (print == "invalid index") {
        console.log("invalid index");
    }
    else if (print == "bigger") {
        console.log("bigger");
    }
    else if (print == "not bigger") {
        console.log("not bigger");
    }
}
printResult(2, [1, 2, 3, 3, 5]);
printResult(2, [1, 2, 5, 3, 4]);
printResult(5, [1, 2, 5, 3, 4]);
printResult(0, [1, 2, 5, 3, 4]);
