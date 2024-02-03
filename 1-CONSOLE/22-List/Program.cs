using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建泛型集合对象
            List<int> nlist = new List<int>();
            nlist.Add(1);
            nlist.AddRange(new int[] { 2, 3, 4, 5 });
            nlist.AddRange(nlist);
            for (int i = 0; i < nlist.Count; i++)
            {
                Console.WriteLine(nlist[i]);
            }
            //List泛型集合可以转换为数组
            int[] n = nlist.ToArray();


            List<string> slist = new List<string>();
            slist.Add("Amy");
            string[] s = slist.ToArray();


            int num = 10;
            //object o = num;//装箱
            //int nm = (int)o;//拆箱
            IComparable ium = num;//继承关系 装箱

            //ArrayList list = new ArrayList();//用/ArrayList会装箱三次 会影响系统、应该避免  备注掉用List则不会
            Stopwatch sw = new Stopwatch();
            sw.Start();//开始计时
            for (int i = 0; i < 3; i++)
            {
                nlist.Add(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
