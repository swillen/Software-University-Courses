function solve(input){
    var regex = /([a-zA-Z\_\.]+\-*[a-zA-Z]*)\s*(\.[0-9a-zA-Z\.]+)\s+([0-9\.]+)/;

    var result = {};
    for (i = 0; i < input.length; i++) {
        var matches = regex.exec(input[i]);
        var name = matches[1];
        var extensions = matches[2];
        var size= parseFloat(matches[3]);
        if(!result[extensions]){
            result[extensions]={
                files:[],
                memory:size
            }
        }

        else{
            var currSize = result[extensions].memory+size;
            result[extensions].memory=currSize;
        }
        result[extensions].files.push(name);
        result[extensions].files.sort();

        result=sortObjByKey(result)
        function sortObjByKey(obj) {
            var sortedObj = {};
            var objKeysSorted = Object.keys(obj).sort();

            for (var j in objKeysSorted) {
                sortedObj[objKeysSorted[j]] = obj[objKeysSorted[j]];
            }

            return sortedObj;
        }

    }
    for(var i in result){
        result[i].memory=result[i].memory.toFixed(2);

    }
    console.log(JSON.stringify(result));
}