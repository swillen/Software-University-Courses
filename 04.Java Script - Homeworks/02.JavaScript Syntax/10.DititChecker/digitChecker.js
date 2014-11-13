function checkDigit(value)  {
	var stringValue = value.toString();
	var strLenght = value.toString().length;
	if (stringValue.charAt(strLenght-3)==3) {
		return console.log("true");
	}else{
		return console.log("false");
	}
	//or return (Math.floor(num / 100) % 10) == 3;
}
checkDigit(1235);
checkDigit(25368);
checkDigit(123456);