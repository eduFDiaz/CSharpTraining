using MyFirstProject.day2.SampleProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Training.day4.ArrayListAndList
{
    class ArrayListDemo
    {
        public static void Main(string[] args)
        {
            // Non Generic Collection
            ArrayList arrayList = new ArrayList();
            
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(true);
            arrayList.Add(false);
            arrayList.Add("abcde");
            arrayList.Add(new Employee("Alex",7));

            if (arrayList.Contains("abcde"))
                Console.WriteLine("The array contains the var {0}", "abcde");

            // arrayList.Reverse();
            foreach(Object element in arrayList)
                Console.WriteLine("object is {0}", element);
        }
    }
}
