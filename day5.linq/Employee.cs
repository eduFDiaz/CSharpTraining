using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day5.linq
{
    class Employee
    {
        public int EId { get; set; }
        public string Name { get; set; }
        public Employee(int id, string name)
        {
            this.EId = id;
            this.Name = name;
        }
    }
}
