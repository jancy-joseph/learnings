using System;
using System.Collections.Generic;
using System.Linq;

namespace threeSum
{
    public static class Test
    {
        public static IList<IList<int>> ThreeSum(int[] nums) 
        {
            if(nums ==null || (nums.Length<3))
            {
                Console.WriteLine("Not enough elements to check");
                return null;
            }
            List<int> numsList = nums.ToList();

            var result = new List<IList<int>>();
            for(int i =0; i<numsList.Count-2; i++)
            {
                for(int j=1;j<numsList.Count-1; j++)
                {
                    for(int k=2; k<numsList.Count; k++)
                    {
                        int sume = nums[i]+nums[j]+nums[k];
                        if( sume== 0)
                        {
                           // Console.WriteLine(sume+$"{i}:{nums[i]}\t{j}:{nums[j]}\t{k}:{nums[k]}") ;
                            List<int> t1 = new List<int>(){nums[i],nums[j],nums[k]};
                            t1.Sort();
                            if(!result.Contains(t1))
                            {
                                result.Add(t1);
                            }
                            else
                            {
                                Console.WriteLine("already in list");
                            }
                        }
                    }
                }
            }
        return result; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numarray = new int[]{-1, 0, 1, 2, -1, -4};
            var result =Test.ThreeSum(numarray);
            if(result!=null)
            {
                foreach(var i in result){
                    Console.Write("[");
                    foreach(var j in i)
                    {
                        Console.Write(j+",");
                    }
                    Console.WriteLine("]");
                }
            }
        }
    }
}
