using System;
using System.Collections.Generic;
using System.Text;
using Add;

namespace Lab1
{
    class Driver
    {
        static void Main(string[] args)
        {
        	addition obj=new addition();
            Console.WriteLine(obj.sum(2,3));
        }
    }
}
