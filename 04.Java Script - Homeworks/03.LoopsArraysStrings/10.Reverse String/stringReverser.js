function reverseString(value) {
    // var reversedString = new Array();
    // for (var i = value.length - 1, j = 0; i >= 0 , j < value.length ; i-- , j++) {
    //     reversedString[j] = value[i];
    // }
    // var string = reversedString.toString();
    // return console.log(string.replace(/,/g, ''));

    //or 

    var backway = value.split("").reverse().join("");
    console.log(backway);
}
reverseString('sample');
reverseString('softUni');
reverseString('java script');