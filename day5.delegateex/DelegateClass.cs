using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.delegateex
{
    public delegate int Calculate(int x, int y);

    class DelegateClass
    {
        public static int Add(int x, int y)
        {
            Console.WriteLine("Inside Add ");
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            Console.WriteLine("Inside Subtract ");
            return x - y;
        }

        public int Divide(int x, int y)
        {
            Console.WriteLine("Inside Divide ");
            return x / y;
        }
    }
}