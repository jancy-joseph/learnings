using System;

namespace VSCodedebugger
{
    public class test
    {
        public void OuterFunc()
        {
            Console.WriteLine("OuterFunc -1");
            InnerFunc();
            Console.WriteLine("OuterFunc -last");

        }

        public void InnerFunc()
        {
            Console.WriteLine("InnerFunc -1");
            Console.WriteLine("InnerFunc -2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            test t = new test();
            t.OuterFunc();
            
        }
    }
}
