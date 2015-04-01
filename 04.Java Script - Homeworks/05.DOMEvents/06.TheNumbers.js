/**
 * Created by Veronica on 30.3.2015 г..
 */
function solve(input){
    
    var splits = /\D/g;
    var values = input[0].split(splits);
    var numbers = [];
    for (item in values) {
        if(values[item]!==''){
            var numb = (parseInt(values[item]).toString(16).toUpperCase());
                var len = numb.length;
                var difference = 4-len;
                var addZeroes = "";
                if(difference!=0){
                    for (var i = 0; i < difference; i++) {
                        addZeroes+="0";
                    }
                    numb = addZeroes+numb;
                }
            numb= "0x"+numb;
            numbers.push(numb);
        }
    }
    console.log(numbers.join("-"));
}
solve(['20']);