using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_DesignPlant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入品牌");
            string brand = Console.ReadLine();
            Laptop laptop = GetLaptop(brand);
            Console.ReadKey();
        }

        /// <summary>
        /// 设计工厂的核心
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static Laptop  GetLaptop(string brand)
        {
            Laptop nb = null; 
            switch (brand)
            {
                
                case "Apple": nb = new Apple();
                    nb.SayName();
                    break;
                case "Microsoft": nb = new Microsoft();
                    nb.SayName();
                    break;
                default:
                    break;
            }
            return nb;
        }
    }
}
