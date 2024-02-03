using System;
using System.Collections.Generic;
using System.Text;

namespace _25_MultiState
{
    public class Square : Shape
    {
        public Square(int radius) : base(radius)
        {

        }

        public override double Area()
        {
            return Radius * Radius;
        }
        public override double Peri()
        {
            return 4 * Radius;
        }
    }
}
