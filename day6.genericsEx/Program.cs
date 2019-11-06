using MyFirstProject.day3.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day6.genericsEx
{
    public class Calculate
    {
        public static bool isEqual<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                Console.WriteLine("They are equal");
                return true;
            }
            else
            {
                Console.WriteLine("They are not equal");
                return false;
            }
        }
        public static void Main() { }
    }
}
