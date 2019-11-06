using System;

namespace MyFirstProject.day2.examples
{
    public class Box
    {
        public int width { get; set; }
        public int length { get; set; }
 
        public int CalculateArea()
        {
            Console.WriteLine("Area is equal to {0}", width * length);
            return width*length;
        }
    }
}