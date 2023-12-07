using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Rectangle
    {
        private float Length;
        private float Width;

        public Rectangle(float length, float width)
        {
            Length = length;
            Width = width;
        }
        public float CalculateArea()
        {
             return Length * Width;
        }
        public void output()
        {
            float area = CalculateArea();
            Console.WriteLine($"The area of Rectangle is {area}.");
        }
    }
   
}
