using System;

namespace _03_Variable
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                //变量类型 变量名
                //变量名=值
                //100
                //int number;//在内存中开辟了一块能够存储整数的空间，不能重复命名（选中关键字按F1可查参考帮助，有int范围等
                //number = 100;//把等号右边的值赋值给左边的变量

                double n = 3.14;//小数
                string zsName = "张三";//字符串 双引号 可以空 可以多
                char gender = '男';//字符 单引号 不能空 最多最少一个字符
                decimal money = 5000m;//不加m则类似double，但decimal解度大很多

                //Console.WriteLine("你好，" + zsName);//加号1. 连接字符串（有一边是字符串时）  2.累加（两边都是数字）
                //Console.ReadKey();
                //Console.WriteLine("5" + 5);//55
                //Console.ReadKey();

                //练习1-变量
                string kkxName = "卡卡西";
                string kkxHome = "木叶村";
                int age = 30;
                string email = "kakaxi@qq.com";
                decimal pay = 2000m;
                Console.WriteLine("我叫" + kkxName + "，我住在" + kkxHome + "，我今年" + age + "了我的邮箱是" + email + "，我的工资" + pay + ".");
                Console.ReadKey();

                int number = 18;
                number = 81;
                Console.WriteLine(number);


                //占位符 n1,n2,n3部分可以多填 不能少填
                int n1 = 10;
                int n2 = 20;
                int n3 = 30;
                Console.WriteLine("第一个数字是{0}，第二个数字是{1}，第三个数字是{2}", n1, n2, n3);//10,20,30
                Console.WriteLine("第一个数字是{1}，第二个数字是{0}，第三个数字是{2}", n1, n2, n3);//20,10,30


                //练习2-占位符
                string name2 = "ICE";
                string gender2 = "female";//char gender2="女"
                int age2 = 24;
                string number2 = "123-45";//int程度限制
                Console.WriteLine("My name is {0}, I am {1} and {2}-year-old, and my number is {3}.", name2, gender2, age2, number2);


                //练习3-交换变量
                int num1 = 10; 
                int num2 = 20;
                int num0 = 0;
                num0 = num2;
                num2 = num1;
                num1 = num0;
                Console.WriteLine("Origin: n1= 10 n2= 20 , and then  n1= {0} n2= {1} ", num1, num2);


                //或者不用第三方（面试要求） 可以用图像来理解
                num1 = 10;
                num2 = 20;
                num2 = num1 + num2;
                num1 = num2 - num1;
                num2 = num2 - num1;
                Console.WriteLine("Origin: n1= 10 n2= 20 , and then  n1= {0} n2= {1} ", num1, num2);




                Console.ReadKey();

            }
        }
    }
}
