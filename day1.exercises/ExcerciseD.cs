using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class ExerciseD
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6};
            PrintArray<int>(array);
            InvertArray<int>(ref array);
            PrintArray<int>(array);
        }
        static void PrintArray<T>(T[] array)
        {
            foreach(T element in array)
            {
                Console.Write(element);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        static void InvertArray<T>(ref T[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                T tmp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = tmp;
            }
        }
    }
}