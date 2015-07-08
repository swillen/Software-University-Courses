function findYoungestPerson(persons)  {
	var compare=Number.MAX_VALUE;
	var position = 0;
	var findThatPerson = {};
	for (var i = 0; i < persons.length; i++) {
		if (persons[i].age<compare) {
			position=i;
			compare=persons[i].age;
		}
	}
	console.log("The youngest person is "+persons[position].firstname+" "+persons[position].lastname );
}
var persons = [
  { firstname : 'George', lastname: 'Kolev', age: 32}, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},
  { firstname : 'Baba', lastname: 'Ginka', age: 40}]
findYoungestPerson(persons);
