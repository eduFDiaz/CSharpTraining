using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day3.inheritance
{
    class Testbox
    {
        static void Main()
        {
            BigBox fedex = new BigBox();
            Console.WriteLine("The area is: {0}", fedex.CalculateArea(4,5));
            Console.WriteLine("The volume is: {0}", fedex.CalculateVolume(4, 5, 2));
        }
    }
}
