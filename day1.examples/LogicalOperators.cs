using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class LogicalOperators
    {
        static void Main()
        {
         
            int x = -10;
            int y = 10;
            if ( x > 0 && y > 0)
            {
                Console.WriteLine("Both of them is gt 0");
                Console.WriteLine("x = {0}, y = {1}", x, 2);
            }

            if (x > 0 || y > 0)
            {
                Console.WriteLine("One of them is gt 0");
                Console.WriteLine("x = {0}, y = {1}", x, 2);
            }

            Console.WriteLine("");
        }
    }
}
