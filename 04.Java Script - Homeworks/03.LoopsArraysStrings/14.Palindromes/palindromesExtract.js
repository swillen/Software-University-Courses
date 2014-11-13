function findPalindromes(value)  {
	var words = value.split(" ");
	var word = "";
	var result = new Array();
	for (var i = 0; i < words.length; i++) {
		word=words[i].replace(/\W/g, '').toLowerCase();
		var rev= word.split('').reverse().join('').toLowerCase();
		if (word== rev) {
			result.push(word);
		}
	}
	console.log(result.join());
}
findPalindromes('There is a man, his name was Bob.'); 

