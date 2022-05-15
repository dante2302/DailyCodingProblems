// Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.

// For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].

// Follow-up: what if you can't use division?


let arr = [1, 2, 3, 4, 5]
function makeNewArr(array){
    let newArray = []
    for(let i = 0;i<array.length;i++){//traverse through the whole array
        let sum = 1
        for(let j = i+1;j<array.length;j++){//add every element after the index
            sum*=arr[j]
        }
        if(i>0){//add every element before the index
            for(let k = i-1;i>=0;k--){
                sum*=arr[k]
            }
        }
        newArray[i] = sum;
    }
    return newArray;
}