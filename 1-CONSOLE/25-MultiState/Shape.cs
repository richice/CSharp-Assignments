using System;
using System.Collections.Generic;
using System.Text;

namespace _25_MultiState
{
    public abstract class Shape
    {
        private int _radius;//CTRL E+R

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }

        }

        public Shape(int radius)
        {
            this.Radius = radius;
        }


        
        public abstract double Area();

        public abstract double Peri();
    }
}
