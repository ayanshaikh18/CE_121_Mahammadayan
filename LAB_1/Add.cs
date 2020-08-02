using System;
using System.Collections.Generic;
using System.Text;

namespace Add
{
    public class Sum
    {
        public static int sum(int a,int b)
        {
            return (a + b);
        }
        public static void Main(){
        	Console.Write("Enter 1 st Number : ");
            int a=Int32.Parse(Console.ReadLine());
        	Console.Write("Enter 2 nd Number : ");
            int b=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sum : "+sum(a,b));
            Console.ReadKey();
        }
    }
}
