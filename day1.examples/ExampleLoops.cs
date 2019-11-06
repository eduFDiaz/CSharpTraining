using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class ExampleIf
    {
        static void Main()
        {
            System.Console.WriteLine("Hello if");
            int x = 10;
            while (x >= 0)
            {
                Console.WriteLine("x = {0}", x);
                x--;
            }

            Console.WriteLine("");

            x = -5;
            do
            {
                Console.WriteLine("x = {0}", x);
                x++;
            } while (x > 0);

                Console.WriteLine("");

            for (int i=10; i >= 0; i--)
            {
                Console.WriteLine("i = {0}", i);
            }

        }
    }
}
