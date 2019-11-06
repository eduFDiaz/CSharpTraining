using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Training.Threading
{
    class ExceptionHandlingDemo
    {
        static void Main(string[] args)
        {
            Demo();
        }

        private static void Demo()
        {
            new Thread(Execute).Start();
        }

        static void Execute()
        {
            try
            {
                throw null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
