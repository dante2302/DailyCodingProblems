// Given an array of integers, find the first missing positive integer. 
//In other words, find the lowest positive integer that does not exist in the array. 
//The array can contain duplicates and negative numbers as well.
// For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
// You can modify the input array in-place.
function findMissing(numbers){
    numbers.sort((a,b)=>{return a-b});
    for(let i = 0, j = 1;i<numbers.length;i++,j++){
            if(numbers[i]<0 && numbers[j]>0){
                let missing = numbers[j] + numbers[i]
                if(missing>1) return numbers[i]+1   }
            else{
                let missing = numbers[j]-numbers[i];
                if(missing>1) return numbers[i]+1}     
    }
    return numbers[numbers.length-1]+1;
}
