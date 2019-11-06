using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day4.statickeyword
{
    class A
    {
        public static int staticcounter { get; set; } = 0;
        public int notstaticcounter { get; set; } = 0;
        public void IncrementStatic()
        {
            Console.WriteLine("static is {0}", staticcounter);
            staticcounter++;
        }
        public void IncrementNotStatic()
        {
            Console.WriteLine("not static is {0}", notstaticcounter);
            notstaticcounter++;
        }
    }
}
