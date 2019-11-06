using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.SampleProject
{
    class Project
    {
        static void Main()
        {
            List<Employee> SalesEmps = new List<Employee>{
                    new Employee("Alex Rod", 6),
                    new Employee("Linda Berry", 7),
                    new Employee("John Doe", 3)
                };
            List<Employee> ITEmps = new List<Employee>{
                    new Employee("Sarah Time ", 7),
                    new Employee("James Doe", 4)
                };
            
            Department SalesDept, ITDept;
            SalesDept = new Department("XYZ Sales", SalesEmps);
            ITDept = new Department("XYZ IT", ITEmps);

            SalesDept.PrintBudget();
            ITDept.PrintBudget();
        }
    }
}
