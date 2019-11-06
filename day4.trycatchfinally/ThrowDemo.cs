using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day4.trycatchfinally
{
    class ThrowDemo
    {   
        public static T DivideNums<T>(T a, T b)
        {
            try
            {
                return (dynamic)a / (dynamic)b;
            }
            catch
            {
                throw new Exception("Please check your numbers");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                int result = DivideNums<int>(6, 0);
                Console.WriteLine("Result: {0}", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("The prgram didn't functioned properly");
            }
        }
    }
}