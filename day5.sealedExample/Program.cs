using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Training.day5.sealedExample
{
    class A
    {
        public virtual void method1()
        { Console.WriteLine("[A] method1"); }
    }

    class B : A
    {
        public sealed override void method1()
        { Console.WriteLine("[B] method1"); }
    }
    class C : B
    {
        public override void method1()
        { Console.WriteLine("[B] method1"); }
    }

    class Program
    {
        static void Main()
        {

        }
    }
}
