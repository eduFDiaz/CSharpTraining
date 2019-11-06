using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.day5.linq
{
    class demoJoin
    {
        static void Main()
        {
            var Employees = new List<Employee>();
            Employees.Add(new Employee(100,"Alex"));
            Employees.Add(new Employee(200, "Lynda"));
            Employees.Add(new Employee(300, "John"));
            
            var Salarys = new List<Salary>();
            Salarys.Add(new Salary(100, 92000));
            Salarys.Add(new Salary(200, 115000));
            Salarys.Add(new Salary(300, 83000));

            // var Seniors = Emps.FindAll(e => e.Grade > 4);
            var emp = from e in Employees.AsQueryable()
                          join s in Salarys.AsQueryable()
                          on e.EId equals s.EId
                          select new Temp(e.Name, s.Money);
                          // Or using an anonymous object
                          // select new { e.Name, s.Money };

            foreach (var e in emp)
                Console.WriteLine(e);
        }
    }
}
