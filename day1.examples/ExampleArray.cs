using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class ExampleArray
    {
        static void Main() {
            int k = 3;
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int[] tmp = new int[array.Length];
            Array.Copy(array, array.Length - k, tmp, 0, k);
            Array.Copy(array, 0, tmp, k, array.Length - k);
            PrintArray<int>(array);
            Console.WriteLine(" ");
            PrintArray<int>(tmp);
        }

        static void PrintArray<T>(T[] array) {
            foreach(T element in array)
                Console.WriteLine(element);
        }
    }
}
