function findLargestBySumOfDigits(nums) {
    var numbers = new Array();
    var number = "";
    var sum = 0;
    var maxSumNumber = 0;
    var maxSum = 0;
    for (var i = 0; i < nums.length; i++) {
        if (typeof (nums[i]) != "number" || nums[i]%1!=0) {
            return console.log("undefined");
        } else {
            numbers.push(nums[i]);
        }
    }
    for (var i = 0; i < numbers.length; i++) {
        number = numbers[i].toString();
        var absNumber = Math.abs(number).toString();
        for (var j = 0; j < absNumber.length; j++) {
            sum += parseInt(absNumber[j]);
            if (sum > maxSum) {
                maxSum = sum;
                maxSumNumber = parseInt(number);
            }
        }
        sum = 0;
    }
    console.log(maxSumNumber);
}
findLargestBySumOfDigits([5, 10, 15, 111]);
findLargestBySumOfDigits([33, 44, -99, 0, 20]);
findLargestBySumOfDigits(['hello']);
findLargestBySumOfDigits([5, 3.3]);