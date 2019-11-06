using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day3.inheritance
{
    class BigBox: Box
    {
        public int height { get; set; }
        public double CalculateArea(double width, double length)
        {
            return width * length * 3;
        }
        public int CalculateVolume(int w, int l, int h)
        {
            this.width = w;
            this.length = l;
            this.height = h;
            return this.width * this.length * this.height;
        }
    }
}
