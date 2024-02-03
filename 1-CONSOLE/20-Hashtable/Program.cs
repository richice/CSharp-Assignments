using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _20_Hashtable
{
    class Program
    {
        private const string daxie = "AASDFG";
        private const string xixie = "aasdfg";
        static void Main(string[] args)
        {
            ////键值对
            //Hashtable ht = new Hashtable();
            //ht.Add(1, "amy");
            //ht.Add(2, "bob");
            //ht.Add(false, "wrong");
            ////键值对对象[键]=值   根据键（必须唯一）去找值（可以重复）
            //ht[4] = "唯一的";

            ////for (int i = 0; i < ht.Count; i++)
            ////{
            ////    Console.WriteLine(ht[i]);
            ////}

            //if (!ht.ContainsKey("abc"))
            //{
            //    ht.Add("abc", "cba");
            //}
            //else
            //{
            //    Console.WriteLine("已经包含abc这个键！");
            //}


            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine("键是————{0}——————值是{1}",item,ht[item]);
            //}


            //////记录程序运行的时间
            ////Stopwatch sw = new Stopwatch();
            ////sw.Start();
            ////ht.Clear();//删除所有
            //ht.Remove(3);

            
            Hashtable ht = new Hashtable();

            for (int i = 0; i < daxie.Length; i++)
            {
                // 添加之前检查键是否已存在
                if (!ht.ContainsKey(daxie[i]))
                {
                    ht.Add(daxie[i], xixie[i]);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("input(ASDFG):");
            string test = Console.ReadLine();
            Console.Write("{0}的小写是", test);
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(ht[test[i]]);
            }
            Console.ReadKey();
        }
    }
}