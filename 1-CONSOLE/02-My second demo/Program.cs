using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_My_second_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;//在内存中开辟了一块能够存储整数的空间-使用变量 先申明 再赋值
            number = 100;

            //这行代码的作用是打印到控制台
            Console.WriteLine("This is my second demo.");
            //暂停当前程序（并且在用户活动后再运行）
            Console.ReadKey();

            String s = "张三";
            string ss = "李四"; //c#独有
        }
    }
}
