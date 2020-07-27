
        newDict[char.toLowerCase()]? (newDict[char.toLowerCase()] > 0? newDict[char.toLowerCase()] -= 1:return false;) : return false;

arr1=[1,2,2,3,7]
arr2=[2,2,6,6,7,7,7]

function intersort(arr1,arr2)
{
    let dict = {};
    let arr3 =[];

        for(var i=0;i<arr1.length; i++ )
        {
            if(arr2.Includes(arr1[i]))
            {
                if(!arr3.includes(arr1[i]))
                {
                arr3.push(arr1[i]);
                }
            }

        }
 
}

function mergeSort(arr)
{
    for (var i=0; i< arr.length ;i++)
    {
        
    }

}