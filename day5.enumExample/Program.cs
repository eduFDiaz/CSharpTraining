using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day5.enumExample
{
    class Program
    {
        public enum Days
        {
            Sat,
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri
        };

        static void Main()
        {
            Days day = Days.Tue;
            Console.WriteLine(day + " " + (int)day);
        }
    }
}
