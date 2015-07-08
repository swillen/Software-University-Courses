function findNthDigit(arr)  {
	var value = Math.abs(arr[1]).toString().replace(".","");
	var n = arr[0];
	var searchedIndex=value[value.length-n];
	if(n<=value.length){
		console.log(searchedIndex);
	}else{
		console.log("undefined ");
	}
}
findNthDigit([1, 6]);
findNthDigit([2, -555]);
findNthDigit([6, 923456]);
findNthDigit([3, 1451.78]);
findNthDigit([6, 888.88]);


