using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training.Threading
{
    class TasksDemo
    {
        static void Main(string[] args)
        {
            Task task = new Task(SimpleMethod);
            task.Start();

            Task<string> taskThatReturns = new Task<string>(MethodThatReturns);
            taskThatReturns.Start();

            Console.WriteLine(taskThatReturns.Result);
        }

        private static string MethodThatReturns()
        {
            Thread.Sleep(2000);
            return "Hello";
        }

        private static void SimpleMethod()
        {
            Console.WriteLine("Hello World");
        }
    }
}
