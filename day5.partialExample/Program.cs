using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day5.partialExample
{
    class Program
    {
        static void Main()
        {
            Box obj = new Box();
            obj.methodA();
            obj.methodB();

            obj.callC();
        }
    }
}
