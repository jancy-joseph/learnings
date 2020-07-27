function arrpartition(arr,left,right,pivot)
{
    if(left==pivot && right==pivot)
        return arr;
    while(arr[left]<= arr[pivot] && left <pivot)
    {
        left++;
    }
     while(arr[right]>=arr[pivot] && right >pivot)
     {
         right--;
     }
     if(left <pivot && right >pivot) // if left is below pivot and right is above pivot
     {
        [arr[left],arr[right]]=[arr[right],arr[left]]; 
        return arrpartition(arr,left+1,right -1);  
     }
     else if(left ==pivot)
        [arr[pivot],arr[right]] = [arr[right],arr[pivot]];
        left = pivot;
        pivot = right;
        return arrpartition(arr,left+1,right,pivot);
     }
     else if(right == pivot)
     {
        [arr[left],arr[right]] = [arr[right],arr[pivot]];

     }

     }


      
}
arr=[5,4,1,0,10,-7,6,2];
var resultarr = arrpartition(arr,0,arr.Length-1,arr.length/2);
console.log(resultarr);