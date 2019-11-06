using System;

namespace MyFirstProject.day2.Overloading
{
    public class Box
    {
        public int width { get; set; }
        public int length { get; set; }
 
        public virtual double CalculateArea(double width, double length)
        {
            return width * length;
        }
    }
}