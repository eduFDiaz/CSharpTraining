using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class ExerciseC
    {
        static void Main()
        {
            string str = "Hello World";
            int index = str.IndexOf("World");
            Console.WriteLine(str.Substring(index).ToLower());
        }
    }
}