using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training.Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintHelloWorld);
            thread.Start();
            // Set the thread as a BackGround Thread
            thread.IsBackground = true;
            // Block the calling thread until it finishes
            thread.Join();
            Console.WriteLine("Hello World printed");
        }

        private static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
            // Sleeps the thread for 5 seconds
            Thread.Sleep(5000);
        }
    }
}
