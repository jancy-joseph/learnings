// var arr1 = [2,5,3,6,7,0,0,23,12];
// var resultarr = [];
// var leftpointer = 0;

// function sum(startindex,endindex,arr)
// {
//     var sum = 0;
//     for(int i =startindex,i <=endindex; i++)
//     {
//         sum +=arr[i];
//     }
//     return sum;
// }

// fucntion consecutiveSums(arr,target)
// {
//     for (int i = 0; i <arr1.length; i++)
//     {

//     }
//     return resultarr;
// }




function sumArray(arr){
    let total = 0
    for (const n of arr){
        total += n
    }
    return total
}

function ConsqSums(arr, k){
    sums = []

    for (var i=0; i< arr.length; i++){
        subArray = [arr[i]]

        if (sumArray(subArray) === k){
            sums.push([arr[i]])
            continue
        }
        
        for (var j=i+1; j<arr.length; j++){
            subArray.push(arr[j])
        
            let s = sumArray(subArray)
            if (s === k){
                sums.push(subArray.slice())                
            }
            else if (s > k){ break }
            
        }
    }
    console.log(sums)
    return sums

}

ConsqSums([2,5,3,6,7,0,0,23,12,16], 16)

// returns ->
// [
//     [ 2, 5, 3, 6 ],
//     [ 3, 6, 7 ],
//     [ 3, 6, 7, 0 ],
//     [ 3, 6, 7, 0, 0 ],
//     [ 16 ]
// ]
