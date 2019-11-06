using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day5.partialExample
{
    public partial class Box
    {
        public void methodA()
        {
            Console.WriteLine("Method A");
        }

        partial void methodC();
    }
}
