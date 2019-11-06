using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Training.Threading
{
    class LocalMemory
    {
        static void Main(string[] args)
        {
            //Worker Thread
            new Thread(PrintOneToThirty).Start();

            //Main Thread
            Thread.CurrentThread.Name = "Main";
            PrintOneToThirty();
        }

        private static void PrintOneToThirty()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + " " + Thread.CurrentThread.Name);
            }
        }
    }
}
