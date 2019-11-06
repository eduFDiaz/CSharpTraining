using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day5.extensionExample
{
    static class ExtensionExample
    {
        public static double divide(this double a, double b)
        {
            return a / b;
        }

        public static string ReverseText(this string str) // extend string
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
