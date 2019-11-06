using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class SwitchCase
    {
        static void Main()
        {
            int x = 4;

            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("x = 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("x = 2");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("x = 3");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Value not in the interval");
                        break;
                    }
            }

            object myobject = new object();
            Console.WriteLine(myobject.GetHashCode());
        }
    }
}
