function soothsayer(value){

	var randYears = value[0][Math.floor(Math.random() * value[0].length)];
	var randLanguage =value[1][Math.floor(Math.random() * value[1].length)];
	var randPlace = value[2][Math.floor(Math.random() * value[2].length)];
	var randCar = value[3][Math.floor(Math.random() * value[3].length)];

	var  result = [randYears,randLanguage,randPlace,randCar];
	return console.log("You will work "+result[0]+" years on "+result[1]+"."+'\n' +"You will live in "+result[2]+" and drive "+result[3]+".");
}
soothsayer([[3, 5, 2, 7, 9], ["Java", "Python", "C#", "JavaScript", "Ruby"], ["Silicon Valley", "London", "Las Vegas", "Paris", "Sofia"]
	, ["BMW", "Audi", "Lada", "Skoda", "Opel"]]);