using System;

namespace Fundamentals_1
{
    public class Test
    {
        //Create a Loop that prints all values from 1-255
        public void PrintallValues(int n)
        {
            for(int i =1; i<=n;i++)
            {
                Console.WriteLine(i);
            }

        }
        //Create a new loop that prints all values from 1-100 that are divisible by 3 or 5,
        // but not both
        public void PrintDivisble(int n)
        {
            for(int i=1; i<n; i++)
            {
                if( i% 3==0 && i%5 ==0){
                    continue;
                }
                else if (i%3 ==0 || i%5 ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, 
        //and "FizzBuzz" for numbers that are multiples of both 3 and 5
         public void PrintFizzBuzz(int n)
        {
            for(int i=1; i<n; i++)
            {
                if( i% 3==0 && i%5 ==0){
                    Console.WriteLine("FizzBuzz");
                }
                else if (i%3 ==0 )
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%5 ==0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }

        //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, 
        //and "FizzBuzz" for numbers that are multiples of both 3 and 5
         public void PrintFizzBuzzWithWhileLoop(int n)
        {
            int i = 1;
            while(i<n)
            {
                if( i% 3==0 && i%5 ==0){
                    Console.WriteLine("FizzBuzz");
                }
                else if (i%3 ==0 )
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%5 ==0)
                {
                    Console.WriteLine("Buzz");
                }
                i++;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test ntest = new Test();
            //ntest.PrintallValues(255);
           // ntest.PrintDivisble(100);
           //ntest.PrintFizzBuzz(16);
           //ntest.PrintFizzBuzzWithWhileLoop(16);
        }
    }
}
