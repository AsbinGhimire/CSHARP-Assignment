using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise4.Shape;

namespace Exercise4
{
    internal class Shape
    {
        public virtual float CalculateArea()
        {
            return 0;
        }

        public class Circle : Shape
        {
            private float Radius;

            public Circle(float radius)
            {
                Radius = radius;
            }

            public override float CalculateArea()
            {
                return (float)(Math.PI * Radius * Radius);
            }

            public void output()
            {
                float area = CalculateArea();

                Console.WriteLine($"The area of the circle having {Radius} radius is {area}");
            }
        }
    }
}
