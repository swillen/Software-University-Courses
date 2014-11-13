function createArray()  {
	var value=[ ];
	for (var i = 0; i <20; i++) {
		value[i]=i*5;
	}
	console.log(value.join());	
}
createArray();