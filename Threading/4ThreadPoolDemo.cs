using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training.Threading
{
    class ThreadPoolDemo
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Chander Dhall";
            employee.CompanyName = "Cazton";

            DisplayEmployeeInfo(employee);

            ThreadPool.QueueUserWorkItem(
                new WaitCallback(DisplayEmployeeInfo), employee);

            var processorCount = Environment.ProcessorCount;
            ThreadPool.SetMaxThreads(processorCount * 2, processorCount * 2);

            int workerThreads = 0;
            int completionPortThreads = 0;
            ThreadPool.GetMinThreads(out workerThreads, out completionPortThreads);

            ThreadPool.SetMaxThreads(workerThreads * 2, completionPortThreads * 2);

            Console.ReadKey();
        }

        private static void DisplayEmployeeInfo(object employee)
        {
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
            Employee emp = employee as Employee;
            Console.WriteLine("Person name is {0} and company name is {1}", emp.Name, emp.CompanyName);
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
    }
}
