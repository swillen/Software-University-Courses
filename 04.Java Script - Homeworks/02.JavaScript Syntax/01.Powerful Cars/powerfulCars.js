function calculateHorsePower (kw) {
	var horsePower = kw/0.745699872;
	return horsePower.toFixed(2);

}
console.log(calculateHorsePower(75));
console.log(calculateHorsePower(150));
console.log(calculateHorsePower(1000));