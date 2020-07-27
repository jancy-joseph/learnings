// function maxsubstringCount(str){
//     let count = 0;
//     var mySet = new Set();
//     for(var i =0; i<str.length; i++)
//     {
//         if (mySet.has(str[i])) {
//             console.log(mySet);
//             if(count < mySet.size) {
//                 count = mySet.size;
//                 mySet.clear();
//             }
//             mySet.add(str[i]);
//         }
//         else{
//             mySet.add(str[i]);
//         }
//         console.log(str[i]);
//     }
//     return count >mySet.size? count: mySet.size;
// 
//  console.log(maxsubstringCount("cabc"));


 function maxsubstringCount(str){
    let count = 0;
    let maxCount = 0;
    var left=0;right = 1;
    if(str.length == 1)
    {
        return 1;
    }
    for(var i =0; i<str.length; i++)
    {
        if(str[left]==str[right] ){
            count = right-left -1;
            if(maxCount< count){
                maxCount = count;
                count = 0;
            }
            left ++;
        }
        else{
            right++;
        }
    }
 
}
 console.log(maxsubstringCount("cabc"));

