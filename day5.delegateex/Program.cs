using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.delegateex
{
    class TestDelegate
    {
        static void Main()
        {
            // for static methods             
            Calculate calc = DelegateClass.Add;
            Console.WriteLine(calc(6, 2)); //8

            calc = DelegateClass.Subtract;
            Console.WriteLine(calc(6, 2)); //4

            // for instance methods       
            DelegateClass obj = new DelegateClass();
            calc = obj.Divide;
            Console.WriteLine(calc(6, 2)); //3

            Console.WriteLine("-----------------------------");

            // multicasting : a chain of methods that will be 
            // automatically called when a delegate is invoked.
            calc = DelegateClass.Add;
            calc += DelegateClass.Subtract;
            calc += obj.Divide;

            //value returned by the last method in the list becomes the              
            //return value of the entire delegate invocation.             
            Console.WriteLine(calc(6, 2)); //3

        }
    }
}