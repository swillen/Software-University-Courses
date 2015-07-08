/**
 * Created by Veronica on 31.3.2015 г..
 */
function solve(input){

    function checkPositions (normandy , system){
        var firstDiff = Math.abs(normandy.x - system.x);
        var secondDiff = Math.abs(normandy.y-system.y);
        if(firstDiff<=1 && secondDiff<=1){
            return true;
        }else{
            return false;
        }


        normandy.y++;
    }
    var firstValue = input[0].split(" ");
    var secondValues = input[1].split(" ");
    var thirdValue = input[2].split(" ");
    var normandyCordinates = input[3].split(" ");
    var moves = parseInt(input[4])+1;

    var normandy  = {
        x:normandyCordinates[0],
        y:normandyCordinates[1]
    }
    var firstSystem = {
        name : firstValue[0],
        x : firstValue[1],
        y:firstValue[2]
    };

    var secondSystem = {
        name :secondValues[0],
        x : secondValues[1],
        y: secondValues[2]
    };
    
    var thirdSystem = {
        name :thirdValue[0],
        x : thirdValue[1],
        y: thirdValue[2]
    };

    for (var i = 0; i < moves; i++) {

       var firsSysCheck = checkPositions(normandy,firstSystem);
       var secondSysCheck = checkPositions(normandy,secondSystem);
        var thirdSysCheck = checkPositions(normandy,thirdSystem);

        if(firsSysCheck===true){
            console.log(firstSystem.name.toLowerCase());
        }else if(secondSysCheck===true){
            console.log(secondSystem.name.toLowerCase());
        }else if(thirdSysCheck===true){
            console.log(thirdSystem.name.toLowerCase());
        }else {
            console.log("space");
        }
        normandy.y++;
    }
}
solve([
    'Terra-Nova 16 2',
    'Perseus 2.6 4.8',
    'Virgo 1.6 7',
    '2 5',
    '4'
])