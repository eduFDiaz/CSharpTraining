using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day5.lambdaExpression
{
    public delegate int Calculate(int x);
    public delegate int Operate(int x, int y);
    class LambadaDemo
    {
        static void Main()
        {
            // expression lambda
            // arguments => expression
            // parameter => expression
            // x becomes x * 2 and return the result;
            // x goes to x * 2
            /*
              int MethodName(int x){
              return x*2;             
            }*/
            Calculate calc = x => x * 2;
            Console.WriteLine(calc(4));
            /*
             int MethodName(int x, int y){
             return x*2;
            }*/
            Operate op = (x, y) => x * y;
            Console.WriteLine(op(2, 3));

            // statement lambada
            op = (x, y) =>
            {
                Console.WriteLine("if method has multiple lines just use curly braces");
                int result = x * y;
                return result;
            };
            Console.WriteLine(op(6, 2));
        }
    }
}