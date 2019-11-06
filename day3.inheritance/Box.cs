using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day3.inheritance
{
    class Box
    {
        public int width { get; set; }
        public int length { get; set; }

        public int CalculateArea(int w, int l)
        {
            this.width = w;
            this.length = l;
            return this.width * this.length;
        }
    }
}
