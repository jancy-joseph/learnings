using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            Console.WriteLine("Print all 1-255");
            // Print all of the integers from 1 to 255.
            for (int i =1; i<=255;i++){
                if(i!= 255)
                {
                    Console.Write(i+",");
                }
                else
                {
                    Console.Write(i);
                    Console.WriteLine();
                }
                
            }

        }
        public static void PrintOdds()
        {
            Console.WriteLine("Print all odds 1-255");
            // Print all of the odd integers from 1 to 255.
            for (int i =1; i<=255;i++){
                if(i%2 !=0){
                    Console.Write(i+",");
                }
                
            }
            Console.WriteLine();
        }
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            Console.WriteLine("print sum 0-255");
            int sum = 0;
            for(int i =0; i<=255; i++){
                sum+=i;
                Console.WriteLine("New number: {0} Sum: {1}",i,sum);
            }
        }
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            Console.WriteLine("Looparray");
            for(int i =0; i<numbers.Length;i++){
                if (i!= numbers.Length -1)
                {
                    Console.Write(numbers[i]+",");
                }
                else
                {
                     Console.Write(numbers[i]);
                     Console.WriteLine();
                }
            }
        }
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            Console.WriteLine("FindMax");
            int arraymax = numbers[0];
            Console.Write(numbers[0]+",");
            for(int i =1; i<numbers.Length; i++){
                if (numbers[i]>arraymax)
                {
                    arraymax = numbers[i];
                }
                Console.Write(numbers[i]+",");
            }
            Console.WriteLine();
            return arraymax;

        }
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            Console.WriteLine("GetAverage");
            int sum = 0;
            int avg = sum/numbers.Length;
            for(int i =0; i<numbers.Length; i++){
                sum+=numbers[i];
                Console.Write("sum :" +sum+",");
            }
            avg = sum/numbers.Length;
            Console.WriteLine();
            Console.WriteLine("Average is "+avg);
        }
        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            Console.WriteLine("Create OddArray: 1-255");
            // Print all of the odd integers from 1 to 255.
            int[] newoddarray = new int[(255/2)+1];
            int k =0;
            for (int i =1; i<=255;i++){
                if(i%2 !=0){
                    newoddarray[k] = i;
                    Console.Write(newoddarray[k]+",");
                    k++;
                }
                
            }
            Console.WriteLine();
            return newoddarray;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            List<int> listOfInts = new List<int>();
            Console.WriteLine("GreaterThanY");
            for(int i =0; i<numbers.Length; i++){
                if(numbers[i]> y){
                    listOfInts.Add(numbers[i]);
                }
            }
            //int[] arrayOfStrings = listOfInts.ToArray();
            return listOfInts.Count;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            Console.WriteLine("SquareArrayValues");
            LoopArray(numbers);
            for(int i =0; i<numbers.Length; i++){
                numbers[i]*=numbers[i];
            }
            LoopArray(numbers);
        }
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            Console.WriteLine("EliminateNegatives");
            LoopArray(numbers);
            for(int i =0; i<numbers.Length; i++){
                if(numbers[i]<0){
                    numbers[i]=0;
                }
                
            }
            LoopArray(numbers);
        }
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            Console.WriteLine("MinMaxAverage");
            int mymin = numbers[0];
            int mymax = numbers[0];
            int mysum = numbers[0];
            Console.Write(numbers[0]+",");
            for(int i =1; i<numbers.Length; i++){
                if(numbers[i]>mymax){
                    mymax = numbers[i];
                }
                if(numbers[i]<mymin){
                    mymin = numbers[i];
                }
                mysum+=numbers[i];
                Console.Write(numbers[i]+",");
            }
            int myavg = mysum/numbers.Length;
            Console.WriteLine();
            Console.WriteLine("Min : "+mymin);
            Console.WriteLine("Max : "+mymax);
            Console.WriteLine("Average : "+myavg);

        }
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            Console.WriteLine("ShiftValues");
            LoopArray(numbers);
            for (int i =0;i<numbers.Length -1; i++)
            {
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length -1] =0;
            LoopArray(numbers);
        }
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            Console.WriteLine("NumToString");
            LoopArray(numbers);
            List<object> newlist = new List<object>();
            for(int i=0; i<numbers.Length;i++){
                if(numbers[i]<0)
                {
                    newlist.Add("Dojo");
                }
                else
                {
                    newlist.Add(numbers[i]);

                }
                
            }
            object[]  test = newlist.ToArray();
            for(int i =0; i<test.Length; i++){
                Console.Write(test[i]+",");
            }
            Console.WriteLine();
            return test;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintNumbers();
            PrintOdds();
            PrintSum();
            int[] num = new int[]{1,2,3,4,5};
            LoopArray(num);
            int [] numarr1 = new int[]{-3, -5, -7};
            int [] numarr2 = new int[]{7, -5, -7,2,0};
            
            Console.WriteLine("Max value is "+FindMax(numarr1));
            Console.WriteLine("Max value is "+FindMax(numarr2));
            LoopArray(num);
            GetAverage(num);
            LoopArray(OddArray());
            Console.WriteLine(GreaterThanY(num,3));
            SquareArrayValues(num);
            EliminateNegatives(numarr2);
            MinMaxAverage(numarr1);
            ShiftValues(numarr1);
            int [] newarr1 = new int[]{-1, -3, 2};
            NumToString(newarr1);
        }
    }
}
