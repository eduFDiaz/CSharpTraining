using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Training.Threading
{
    class ContextSwitching
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteUsingNewThread);
            thread.Name = "Cazton Worker";
            //Worker Thread
            thread.Priority = ThreadPriority.Highest;
            thread.Start();

            //Main Thread
            Thread.CurrentThread.Name = "Cazton main";
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(" A" + i + " ");
            }
        }

        private static void WriteUsingNewThread()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(" Z" + i + " ");
            }
        }
    }
}
