using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27_Supermarket
{
    class Warehouse
    {
        // 1. 存
        ////1-1 List<Juice> listJui = new List<Juice>();
        ////List<Acer> listAce = new List<Acer>();
        //1-2 List<Store> list = new List<Store>();//子类存给父类 但是不好找 
        //1-3 list[0]存储juice list[1]存储acer
        List<List<Store>> list = new List<List<Store>>();//重要！ 仓库中加货架


        /// <summary>
        /// 创建仓库对象的时候向仓库中添加货架
        /// </summary>
        public Warehouse()//构造函数
        {
            list.Add(new List<Store>());//加两个货架
            list.Add(new List<Store>());
        }

        // 2. 进
        public void GetPros(string name, int count)//来啥货 来几个
        {
            for (int i = 0; i < count; i++)
            {
                switch (name)
                {
                    case "Juice":
                        list[0].Add(new Juice("Juice", 500, Guid.NewGuid().ToString(), 4));
                        break;
                    case "Acer":
                        list[1].Add(new Acer("Acer", 5, Guid.NewGuid().ToString(), 1000));
                        break;
                    default:
                        break;
                }
            }
        }

        // 3. 取
        public Store[] TakePros(string name, int count)
        {
            Store[] pros = new Store[count];
            for (int i = 0; i < count; i++)
            {
                switch (name)
                {
                    case "Juice":
                        if (list[0].Count > 0)
                        {
                            pros[i] = list[0][0];//[货架][第一个]赋值
                            list[0].RemoveAt(0);//撤货
                        }
                        else
                        {
                            Console.WriteLine("Juice缺货！");
                        }
                        break;
                    case "Acer":
                        if (list[1].Count > 0)
                        {
                            pros[i] = list[1][0];
                            list[1].RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("Acer缺货！");
                        }
                        break;
                    default:
                        break;
                }
            }
            return pros;

        }

        // 展示
        public void ShowPros()
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Count > 0)
                {
                    Console.WriteLine($"货架{i + 1}商品信息：");

                    // 只展示两行
                    var firstItem = list[i].FirstOrDefault();
                    Console.WriteLine($"{firstItem.Name}有{list[i].Count}个，单价{firstItem.Price}元");

                    // 使用 "_______" 分隔不同货架的信息
                    Console.WriteLine("__________");
                }
                else
                {
                    Console.WriteLine($"货架{i + 1}暂无商品！");
                }
            }
        }
    }
}