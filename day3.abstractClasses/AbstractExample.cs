using System;

namespace MyFirstProject.day3.abstractClasses
{
    public class AbstractExample
    {
        static void Main()
        {
            Cone cone = new Cone();
            Console.WriteLine("Volume of cone is {0}", cone.CalculateVolume(1,1));

            Cube cube = new Cube();
            Console.WriteLine("Volume of cube is {0}", cube.CalculateVolume(1,1));
        }
    }
}