// This problem was asked by Microsoft.
// Compute the running median of a sequence of numbers. 
//That is, given a stream of numbers, print out the median of the list so far on each new element.
// Recall that the median of an even-numbered list is the average of the two middle numbers.


const medianFinder = (list) => {
    let runningList = []

    list.forEach((element)=>{
        runningList.push(element)
        runningList.sort((a,b)=>(a-b))
        console.log(runningList)
        if((runningList.length%2==0)) console.log((runningList[runningList.length/2-1] + runningList[runningList.length/2])/2) 
        else console.log(runningList[Math.floor(runningList.length/2)])
    })
}
