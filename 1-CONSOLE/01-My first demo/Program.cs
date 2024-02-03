using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace _01_My_first_demo
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }

        /// <summary>
        /// 这个方法旨在求两个整数中的最大值
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回最大值</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
}

    /// <summary>
    /// 这个类描述人的信息 从名字和年龄
    /// </summary>
    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
    }
}
