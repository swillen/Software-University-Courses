function calcSupply(age,maxAge,favFood,foodPerDay){
	var totalDays = (maxAge-age)*365;
	return console.log(foodPerDay*totalDays+" kg of "+favFood+" will be enough until i am "+maxAge+" years old." );
}
calcSupply(38,118,"chocolate",0.5);
calcSupply(20,87,"fruits",2);
calcSupply(16,102,"nuts",1.1);