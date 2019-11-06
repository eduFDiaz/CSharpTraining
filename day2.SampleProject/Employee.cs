using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.SampleProject
{
    class Employee: IComparable<Employee>
    {
        public string Name { get; set; }
        public int Grade { get; private set; }
        public Employee(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return "Emp "+ this.Name + " Grade " + this.Grade;
        }

        public int CompareTo(Employee other)
        {
            return this.Grade.CompareTo(other.Grade);
        }
    }
}
