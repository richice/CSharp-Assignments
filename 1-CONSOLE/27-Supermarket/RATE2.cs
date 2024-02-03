using System;
using System.Collections.Generic;
using System.Text;

namespace _27_Supermarket
{
    class RATE2:Discount
    {
        public double GOAL
        {
            get;
            set;
        }
        public double FREE
        {
            get;
            set;
        }
        public RATE2(double goal,double free)
        {
            this.GOAL = goal;
            this.FREE = free;
        }
        public override double GetTotal(double money)
        {
            if (money > this.GOAL)
            {
                return money - this.FREE * (int)(money/ this.GOAL);
            }
            else
            {
                return money;
            }
        }
    }
}
