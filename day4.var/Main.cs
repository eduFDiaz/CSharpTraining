using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day4.var
{
    class VarDemo
    {
        public static void Main(string[] args)
        {
            //var x; // Error, must be initialized
            var x = 2.6;
            //x = "abc"; Error, x is double and can't hold a string
            Console.WriteLine("var is {0}", x);
        }
    }
}
