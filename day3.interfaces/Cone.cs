using System;

namespace MyFirstProject.day3.interfaces
{
    public class Cone : Container
    {
        public double CalculateAreaOfBase(int length)
        {
            return (double)(Math.PI * Math.Pow(length, 2));
        }

        public double CalculateVolume(int width, int height)
        {
            return (double)(1.0/3.0 * CalculateAreaOfBase(width) * height);
        }
    }
}