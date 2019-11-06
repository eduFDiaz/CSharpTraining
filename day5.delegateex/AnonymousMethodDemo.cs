using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day5.delegateex
{
    class AnonymousMethodDemo
    {
        public delegate int Calculate(int x, int y);
        static void Main()
        {
            Calculate calc = delegate (int x, int y)
            {
                Console.WriteLine("Add ");
                return x + y;
            };

            Console.WriteLine(calc(6, 2));

            calc += delegate (int x, int y)
            {
                Console.WriteLine("Subtract ");
                return x - y;
            };

            Console.WriteLine(calc(6, 2));
        }
    }
}
