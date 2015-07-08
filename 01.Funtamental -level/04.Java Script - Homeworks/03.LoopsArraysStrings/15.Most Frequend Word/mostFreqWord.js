function findMostFreqWord(value) {
    var words = value.toLowerCase().split(/[^a-zA-Z]+/g);
    var counter = 1;
    var maxCounter = 1;
    var maxValue = "";
    var arrList = new Array();
    for (var i = 0; i < words.length; i++) {

        for (var j = 0; j < words.length; j++) {
            if (words[i] == words[j] && i != j && j > i) {
                counter++;
            }
        }
        if (counter != 1) {
            if (counter >= maxCounter) {
                maxCounter = counter;
                maxValue = words[i];
                arrList.push(words[i]);
            }
        }
        counter = 1;
    }
    if (arrList.length == 0) {
        for (i = 0; i < words.length - 1; i++) {
            console.log(words[i] + " -> " + "1 time");
        }
    }

    if (arrList.length == 1) {
        console.log(arrList[0] + " -> " + maxCounter + " times");
    } else if (arrList.length > 1) {
        arrList.sort();
        for (i = 0; i < arrList.length; i++) {
            console.log(arrList[i] + " -> " + maxCounter + " times");
        }
    }
}
findMostFreqWord('in the middle of the night.');
findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.');
findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');
findMostFreqWord('in the middle.');