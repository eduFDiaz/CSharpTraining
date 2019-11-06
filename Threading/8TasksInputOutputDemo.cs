using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training.Threading
{
    class TasksInputOutputDemo
    {
        static bool isCompleted = false;
        static readonly object lockCompleted = new object();
        static void Main(string[] args)
        {
            Task<string> task1 = Task.Run(() => PrintText("Text 1"));
            Task<string> task2 = Task.Run(() => PrintText("Text 2"));

            try
            {
                Console.WriteLine(task1.Result);
                Console.WriteLine(task2.Result);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static string PrintText(string text)
        {
            lock (lockCompleted)
            {
                if (!isCompleted)
                {
                    isCompleted = true;
                    text += " Appended only once";
                }
            }
            return text;
        }
    }
}
