using System;
using System.Collections.Generic;
using System.Text;

namespace _27_Supermarket
{
    class OpenSupermarket
    {

        //创建仓库对象
        Warehouse WH = new Warehouse();
        public OpenSupermarket()
        {
            WH.GetPros("Acer", 100);
            WH.GetPros("Juice", 2000);
        }

        //交易交互
        public void Purchase()
        {
            double money = 0;
            while (true)
            {
                Console.WriteLine("你要买什么？我们有Acer，Juice；如不需要请quit");
                string name = Console.ReadLine();
                if (name=="quit")
                {
                    break;
                }
                Console.WriteLine("要几个？");
                int count = Convert.ToInt32(Console.ReadLine());

                //取货
                Store[] ST = WH.TakePros(name, count);
                if (ST != null && ST.Length > 0 && ST[0] != null)
                {
                    // 算账
                    money += ST[0].Price * count;
                    Console.WriteLine($"请支付{money}元");

                    // 打折方式
                    Console.WriteLine("你要参加活动吗？1-不参加 2-85折 3-买300送50");
                    string discount = Console.ReadLine();
                    // 设计工厂得到打折对象
                    Discount ds = GetDiscount(discount);

                    if (ds != null)
                    {
                        money = ds.GetTotal(money);
                        Console.WriteLine($"折后请支付{money}元");
                    }
                    else
                    {
                        Console.WriteLine("无效的打折方式，未进行打折。");
                    }
                }
                else
                {
                    Console.WriteLine("商品信息有误，请重新选择。");
                }
                Console.WriteLine("以下是您的购物信息");
                foreach (var item in ST)
                {
                    Console.WriteLine("货物名称：" + item.Name + "\t"+ "货物单价：" + item.Price + "\t" + "货物编号："+ item.ID);
                }                
            }
        }

        public Discount GetDiscount(string discount)
        {
            Discount ds = null;
            switch (discount)
            {
                case "1":
                    ds = new RATE1(1);
                    break;
                case "2": ds = new RATE1(0.85);
                    break;
                case "3": ds = new RATE2(300, 50);
                    break;
                default:
 break;
            }
            return ds;
        }

        public void ShowPros()
        {
            WH.ShowPros();
        }
    }
}
