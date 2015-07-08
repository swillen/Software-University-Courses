function sortArray(value) {
    for (var i = 0; i < value.length; i++) {
        var temp = 0;
        
        for (var j = 1; j < value.length; j++) {
            if (value[j] <=value[i] && i!=j && i<j) {             
                temp = value[i];
                value[i] = value[j];
                value[j] = temp;
            } 
        }
    }
    return console.log(value);
}
sortArray([5, 4, 3, 2, 1]);
sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]);



//second way 
//unction sortArray(value) {
 //var newArr = new Array();
    //var temp = 0;
    //var temp2;
    //for (var i = 0; i < value.length - 1; i++) {
    //    temp = i;
    //    for (var c = i+1; c < value.length; c++) {
    //        if (value[c] < value[temp]) {
    //            temp = c;
    //        }
    //    }
    //    if (temp != i) {
    //        temp2 = value[temp];
    //        value[temp] = value[i];
    //        value[i] = temp2;    
    //    }
    //}
    //console.log(value);
    //}
    //sortArray([12, 50, 2, 6, 22, 51, 712, 6, 3, 3]);