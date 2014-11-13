function checkBrackets(value)  {
	var splitsEach = value.split("").join("");
	var leftBrackets = 0;
	var rightBrackets = 0;
	for (var i = 0; i < splitsEach.length; i++) {
		if(splitsEach[i]==="(" && splitsEach[0]=='('){
			leftBrackets++;
		}
		if(splitsEach[i]===")" && splitsEach[splitsEach.length-1]==')'){
			rightBrackets++;
		}
	}
	if (leftBrackets==rightBrackets) {
		return console.log('correct');
	}else{
		return console.log('incorrect');
	}
}
checkBrackets('( ( a + b ) / 5 – d )');
checkBrackets(') ( a + b ) )');
checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )');