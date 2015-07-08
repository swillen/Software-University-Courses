function solve (input){
    var bill = parseFloat(input[0]);
    var mood  = input[1];
    var tip;
    if(mood==='happy'){
        tip = bill * 10/100;
        console.log(tip.toFixed(2));
    }else if(mood==='married'){
        tip = bill * 0.05/100;
        console.log(tip.toFixed(2));
    }else if(mood==='drunk'){
        tip = bill * 15/100;
        var firstDigit = parseInt(tip.toString()[0]);
        tip = Math.pow(tip,firstDigit);
        console.log(tip.toFixed(2));
    }else {
        tip = bill * 5/100;
        console.log(tip.toFixed(2));
    }
}
solve([716.00,'married']);
//solve([200,'drunk']);