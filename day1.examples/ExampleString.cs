using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class ExampleString
    {
        static void Main()
        {
            string k = "Hello world world1";
            int index = k.IndexOf("world1");
            PrintArray<char>(k.Substring(index).ToCharArray());
            string[] array = k.Split();
            PrintArray<string>(array);
            Console.WriteLine(double.Parse("34.2")+1);
            Console.WriteLine(Convert.ToDouble("34.2") + 1);
        }

        static void PrintArray<T>(T[] array) {
            foreach (T element in array) { 
                Console.Write(element);
                Console.Write(' ');
            }
            Console.WriteLine("");
        }
    }
}
