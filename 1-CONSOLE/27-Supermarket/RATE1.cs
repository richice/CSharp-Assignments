using System;
using System.Collections.Generic;
using System.Text;

namespace _27_Supermarket
{
    class RATE1:Discount
    {
        public double Rate
        {
            get;
            set;
        }

        public RATE1(double rate)
        {
            this.Rate = rate;
        }

        public override double GetTotal(double money)
        {
            return money * this.Rate;
        }


    }
}
