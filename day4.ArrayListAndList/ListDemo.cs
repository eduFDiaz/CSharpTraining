using MyFirstProject.day2.SampleProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Training.day4.ArrayListAndList
{
    class ListDemo
    {
        public static void Main(string[] args)
        {
            // Generic Collection
            List<string> list = new List<string>();

            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");

            if (list.Contains("abcd"))
                Console.WriteLine("The array contains the var {0}", "abcd");

            // arrayList.Reverse();
            foreach (Object element in list)
                Console.WriteLine("element is {0}", element);
        }
    }
}
