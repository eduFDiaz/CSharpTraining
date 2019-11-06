using System;

namespace  MyFirstProject.day3.interfaces
{
    public class Cube : Container
    {
        public double CalculateAreaOfBase(int width)
        {
            return Math.Pow(width,2);
        }

        public double CalculateVolume(int width, int height)
        {
            return CalculateAreaOfBase(width) * height;
        }
    }
}