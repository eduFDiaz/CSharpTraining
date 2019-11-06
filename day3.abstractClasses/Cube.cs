using System;

namespace MyFirstProject.day3.abstractClasses
{
    public class Cube : Container
    {
        public override double CalculateAreaOfBase(int width)
        {
            return Math.Pow(width,2);
        }

        public override double CalculateVolume(int width, int height)
        {
            return CalculateAreaOfBase(width) * height;
        }
    }
}