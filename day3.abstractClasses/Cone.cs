using System;

namespace MyFirstProject.day3.abstractClasses
{
    public class Cone : Container
    {
        public override double CalculateAreaOfBase(int length)
        {
            return Math.PI * Math.Pow(length, 2);
        }

        public override double CalculateVolume(int width, int height)
        {
            return 1.0/3.0 * CalculateAreaOfBase(width) * height;
        }
    }
}