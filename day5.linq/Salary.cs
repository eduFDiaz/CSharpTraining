using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day5.linq
{
    class Salary
    {
        public int EId { get; set; }
        public int Money { get; set; }
        public Salary(int id, int salary)
        {
            this.EId = id;
            this.Money = salary;
        }
    }
}
