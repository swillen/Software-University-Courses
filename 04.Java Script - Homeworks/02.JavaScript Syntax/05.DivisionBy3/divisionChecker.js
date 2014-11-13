//if number is devided by 3 so and  the sum of it`s digits
function divisionBy3(value) {
	if (value%3==0) {
		return "the number is divided by 3 without remainder";
	}
	else{
		return 'the number is not divided by 3 without remainder';
	}
}
console.log(divisionBy3(12));
console.log(divisionBy3(188));
console.log(divisionBy3(591));