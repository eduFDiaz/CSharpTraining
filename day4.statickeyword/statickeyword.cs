using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day4.statickeyword
{
    class statickeyword
    {
        public static void Main(string[] args)
        {
            A a = new A();
            A b = new A();

            a.IncrementStatic();//0
            a.IncrementStatic();//1
            a.IncrementStatic();//2
            A.staticcounter++;  //3

            b.IncrementStatic();//4

            a.IncrementNotStatic();//0
            a.IncrementNotStatic();//1
            a.IncrementNotStatic();//2

            b.IncrementNotStatic();//0
            b.IncrementNotStatic();//1

        }
    }
}
