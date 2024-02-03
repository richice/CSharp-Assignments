using System;
using System.Collections.Generic;
using System.Text;

namespace _25_MultiState
{
    public class Circle: Shape
    {
        public Circle(int radius):base(radius)
        {

        }

        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }
        public override double Peri()
        {
            return 3.14 * 2 * Radius;
        }
    }
}
