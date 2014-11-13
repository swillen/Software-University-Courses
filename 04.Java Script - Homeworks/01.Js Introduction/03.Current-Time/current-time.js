	var hours = new Date().getHours();
	var minutes = new Date().getMinutes();
	if (minutes<10) {
		minutes="0"+minutes;
	} 
	console.log(hours+":"+minutes);
