using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.SampleProject
{
    class Department
    {
        public string Name { get; set; }
        public double Budget { get; set; }
        public List<Employee> Employees { get; set; }

        public Department(string name, List<Employee> employees) 
        {
            this.Name = name;
            this.Employees = employees;
            this.Budget = 50000;
            foreach(Employee employee in this.Employees)
            {
                if(employee.Grade >= 5)
                {
                    this.Budget += 150000;
                } else {
                    this.Budget += 100000;
                }
            }
        }

        public void PrintBudget()
        {
            Console.WriteLine("The budget of {0} is {1}", this.Name, this.Budget);
            Console.Write("Employees: ");
            foreach(Employee emp in this.Employees)
                Console.Write(emp.Name + ", ");
            Console.WriteLine("\n...................");
        }
    }
}
