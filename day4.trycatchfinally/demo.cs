using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day4.trycatchfinally
{
    class demo
    {
        public static void Main(string[] args)
        {
            try
            {
                int i = 1;
                double div = i / 0;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Some error ocurred");
                Console.WriteLine("Standard message: {0}", e);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Stack trace: {0}", e.StackTrace);
                Console.WriteLine("Target site: {0}", e.TargetSite);
                Console.WriteLine("Source: {0}", e.Source);
            }
            finally
            {
                Console.WriteLine("The prgram didn't functioned properly");
            }
        }
    }
}
