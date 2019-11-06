using System;

namespace MyFirstProject.day2.examples
{
    class Employee
    {
        public double salary { get; set; }
        public double bonus { get; set; }

        public void CalculateTotalPay()
        {
            Console.WriteLine("{0}'s total pay is {1}", this.GetType().Name, salary + bonus);
        }
    }
}
