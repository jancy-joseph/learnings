using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        public class ListManipulation
        {
            public void FindSumofIntObjects()
            {
                int SumofintObjects = 0;
                List<object>  listofObjects= new List<object>{7, 28, -1, true, "chair"};
                for(int i =0; i<listofObjects.Count;i++)
                {
                        var currobj = listofObjects[i];
                        if (currobj is int)
                        {
                            SumofintObjects +=(int) currobj;
                        }
                        if(i!= listofObjects.Count -1){
                            Console.Write(currobj+",");
                        }
                        else
                        {
                             Console.Write(currobj);
                             Console.WriteLine();
                        }

                }
                Console.WriteLine("Sum of all Int Objects is  :"+SumofintObjects);

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListManipulation lmp = new ListManipulation();
            lmp.FindSumofIntObjects();
        }
    }
}
