using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class ExerciseA
    {
        static void Main()
        {
            Console.WriteLine("Enter the salary");
            uint input = Convert.ToUInt32(Console.ReadLine());
            uint salary = input;
            double tax;
            if (salary <= 8350)
            {
                tax = salary * 0.10;
            } else if ( salary > 8350 && salary <= 33950)
            {
                tax = 8350*0.10 + (salary-8350) * 0.15;
            } else
            {
                tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (salary-33950)*.25;
            }
            Console.WriteLine("Tax to pay of salary {0} = {1}", salary, tax);
        }
    }
}