using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day5.linq
{
    class Temp
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Temp(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return "Name: " + this.Name + " Salary: " + this.Salary.ToString();
        }
    }
}
