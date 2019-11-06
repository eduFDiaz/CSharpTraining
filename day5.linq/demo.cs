using MyFirstProject.day2.SampleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.day5.linq
{
    class demo
    {
        static void Main()
        {
            List<Employee> SalesEmps = new List<Employee>{
                    new Employee("Alex Rod", 6),
                    new Employee("Linda Berry", 7),
                    new Employee("John Doe", 3),
                    new Employee("Sarah Time", 7),
                    new Employee("James Doe", 4)
                };

            Department SalesDept;
            SalesDept = new Department("XYZ Sales", SalesEmps);

            // var Seniors = Emps.FindAll(e => e.Grade > 4);
            var Seniors = from e in SalesDept.Employees.AsQueryable()
                          where e.Grade > 4
                          select e;

            foreach (var e in Seniors)
                Console.WriteLine(e);

            Console.WriteLine("Count: {0}:", Seniors.Count());
            Console.WriteLine("Max: {0}:", Seniors.Max());
            Console.WriteLine("Min: {0}:", Seniors.Min());
            Console.WriteLine("Average of Grades: {0}:", Seniors.Average(e => e.Grade));
            Console.WriteLine("Sum of Grades: {0}:", Seniors.Sum(e => e.Grade));
        }
    }
}
