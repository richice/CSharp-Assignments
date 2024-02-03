using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Static
{
    public class Ticket
    {

        private static double _distance;
        public double Distance
        {
            get { return Ticket._distance; }//表示本属性只读
        }


        //在构造函数中赋值
        public Ticket(double distance)
        {
            
                if (distance < 0)
                {
                distance = 0;
                }
            Ticket._distance = distance;//赋值给字段
        }

        private static double _price;
        public double Price
        {
            get
            {
                switch (Convert.ToInt32(_distance)/100)
                {
                    case 0: return _distance*1;
                    case 1: return _distance * 0.95;
                    case 2: return _distance * 0.85;
                    default:
                        return _distance * 0.75;
                }
            }
        }

        public void ShowInf()
        {
            Console.WriteLine("{0}公里需要{1}元", Distance, Price);//不能_price 因为Price才使用get方法
        }
    }
}
