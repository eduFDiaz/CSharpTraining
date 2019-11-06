using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day5.extensionExample
{
    class Program
    {
        static void Main()
        {
            double a = 10;
            Console.WriteLine(a.divide(2)); // 10/2 = 5

            string str = "World";
            Console.WriteLine(str.ReverseText()); //dlroW
        }
    }
}
