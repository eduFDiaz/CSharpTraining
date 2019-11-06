using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day4.basekeyword
{
    class Cube : Square
    {
        protected int somenumber = 20;
        public override double CalculateArea(int length)
        {
            Console.WriteLine("Cube some number {0}", somenumber);
            Console.WriteLine("Square some number {0}", base.somenumber);
            double area = base.CalculateArea(length) * 6;
            return area;
        }
    }
}
