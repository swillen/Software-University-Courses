function treehouse(a, b) {
	var house = (Math.pow(a, 2) + a * (a * (2 / 3)) / 2).toFixed(2);
	var tree = (b * (b * (1 / 3)) + Math.PI * (b * (2 / 3)) * (b * (2 / 3))).toFixed(2);
	if (house > tree) {
	    return console.log("house/" + house);
	} else {
	    return console.log("tree/" + tree);
	}
}
treehouse(3, 2);
treehouse(3, 3);
treehouse(4, 5);