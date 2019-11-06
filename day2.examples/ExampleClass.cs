using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.examples
{
    class ExampleClass
    {
        static void Main()
        {
            Employee alex = new Employee();
            Employee lynda = new Employee();
            
            alex.salary = 90000;
            alex.bonus = 11000;
            alex.CalculateTotalPay();

            lynda.salary = 90000;
            lynda.bonus = 20000;
            lynda.CalculateTotalPay();

            Box ups, fedEx;
            ups = new Box();
            fedEx = new Box();
            
            ups.width = 5;
            ups.length = 4;
            int total = ups.CalculateArea();

            fedEx.width = 3;
            fedEx.length = 3;
            total += fedEx.CalculateArea();

            Console.WriteLine("Total area is {0}", total);

            SmallBox littleBox = new SmallBox(4,5);
            total += littleBox.CalculateArea();
            Console.WriteLine("Total area is {0}", total);
        }
    }
}
