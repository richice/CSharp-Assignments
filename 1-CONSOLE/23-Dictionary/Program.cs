using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "amy");
            //dic.Add(2, "BOB");
            //dic[1] = "AMY";//覆盖
            //foreach (KeyValuePair<int, string> kv in dic)//遍历键值对 法二
            //{
            //    Console.WriteLine("{0}---{1}", kv.Key, kv.Value);
            //}
            ////foreach (var item in dic.Keys)//遍历键 法一
            ////{
            ////    Console.WriteLine("{0}---{1}", item,dic[item]);
            ////}


            ////练习1 奇偶集合
            ////Console.WriteLine("输入数组");
            //int[] set = { 1, 2,2,2,2,2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////int[] jishu = new int[0];
            ////int[] oushu = new int[0];
            //List<int> jishu = new List<int>();
            //List<int> oushu = new List<int>();
            //for (int i = 0; i < set.Length; i++)
            //{
            //    if (set[i]%2==1)
            //    {
            //        jishu.Add(set[i] );
            //    }
            //    else
            //    {
            //        oushu.Add(set[i]);
            //    }
            //}
            //jishu.AddRange(oushu);
            //foreach (var item in jishu)
            //{
            //    Console.Write(item+" ");

            //}
            //Console.WriteLine();

            ////练习2 字符数组
            //Console.WriteLine("输入字符串（会赋值给字符数组）");
            //string input = Console.ReadLine();
            //char[] c = input.ToCharArray();
            //foreach (var item in c)
            //{
            //    Console.Write(item + " ");

            //}
            //Console.WriteLine();


            //练习3 每个字符出现的数字
            string c = "Welcome to my life";
            
            Dictionary<char, int> xixi = new Dictionary<char, int>();
            foreach (var item in c)
            {
                char key = char.ToLower(item);// 忽略大小写比较

                if (item == ' ')//单引号！字符串是由双引号括起来的，而字符应该用单引号括起来。
                {
                    continue;
                } 
                else if (xixi.ContainsKey(item))
                {
                    xixi[item] += 1;
                }
                else
                {
                    xixi[item] = 1 ;
                }
            }

            foreach (var item in xixi)
            {
                Console.WriteLine("{0}_______{1}", item.Key, item.Value);
            }            
            Console.ReadKey();
        }
    }
}
