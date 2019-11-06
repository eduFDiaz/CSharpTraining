using System;

namespace MyFirstProject.day3.abstractClasses{
    public abstract class Container{
        public abstract double CalculateVolume(int width, int height);
        public abstract double CalculateAreaOfBase(int width);
    }
}