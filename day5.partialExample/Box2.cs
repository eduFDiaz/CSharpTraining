using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day5.partialExample
{
    partial class Box
    {
        public void methodB()
        {
            Console.WriteLine("Method B");
        }

        partial void methodC()
        {
            Console.WriteLine("Method C");
        }
    }

    partial class Box
    {
        public void callC()
        {
            methodC();
        }
    }
}
