using System;

namespace MyFirstProject.day1.examples
{
    public class ExampleOne
    {
        static void Main()
        {
            Console.WriteLine("Hello world");

            int[] myarray = new int[] { 1, 2, 3, 4, 5 };
            int x = 10;
            int y = 3;
            int result = x % y;
            Console.WriteLine("{0} % {1} = {2} ", x, y, result);
            Console.WriteLine("{0} ", myarray.ToString());
        }
    }
}