using System;
using System.Collections.Generic;
using System.Text;

using System.Reflection;
[assembly: AssemblyVersion("1.0.0.0")]

namespace arithmetic
{
    public class calc
    {
        public int addition(int x,int y)
        {
        	Console.WriteLine("In addition of Newer Version");
            return x + y;
        }
        public int multiplication(int x,int y)
        {
        	Console.WriteLine("In multiplication of Newer Version");
            return x * y;
        }
    }
}