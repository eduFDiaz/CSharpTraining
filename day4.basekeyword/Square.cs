using System;
using System.Collections.Generic;
using System.Text;

namespace Training.day4.basekeyword
{
    class Square
    {
        protected int somenumber = 10;
        public virtual double CalculateArea(int length)
        {
            return (length * length);
        }
    }
}
