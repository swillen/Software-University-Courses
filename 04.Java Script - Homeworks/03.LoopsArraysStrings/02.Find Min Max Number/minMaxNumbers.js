function findMinAndMax(value)  {
	var maxArray = Math.max.apply(Math, value);
	var minArray = Math.min.apply(Math, value);
	console.log("Min -> "+minArray+'\n'+"Max -> "+maxArray+'\n');
}

findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]);
findMinAndMax([2, 2, 2, 2, 2]);
findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]);


