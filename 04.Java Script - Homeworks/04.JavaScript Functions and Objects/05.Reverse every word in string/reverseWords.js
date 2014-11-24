//made it a little complicated

function splitTheWords(str)  {
	var splitWords = str.split(" ");
	return splitWords;
}
function reverseWords(str){
	var getWords = splitTheWords(str);
	var reversedArr=new Array();
	for (var i = 0; i < getWords.length; i++) {
		var word=getWords[i];
		for (var j = word.length-1; j>= 0; j--) {
			var reversedWord=word[j];
			reversedArr.push(reversedWord);
		}
		reversedArr.push(" ");
	}
	return reversedArr.join("");
}
function printResult (str) {
	var finalResult = reverseWords(str);
	return console.log(finalResult);
}
printResult('Hello, how are you.');
printResult('Life is pretty good, isn’t it?');