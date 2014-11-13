function  isPrime(value) {
	var sqareOfVal = Math.round(Math.sqrt(value));
	var prime = false;
	if (value==0 || value==1 || value == 2) {
		prime=false;
	}else if(value>1){
		for (var i = 2; i <=sqareOfVal; i++) {
			if (value%i==0) {
				prime=false;
				break;
			}else{
				prime=true;
				continue;
			}
		}
	}
	return prime;
}
console.log(isPrime(7));
console.log(isPrime(254));
console.log(isPrime(587));
