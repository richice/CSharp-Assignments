using System;

namespace _11_Function
{
    class Program
    {
        //C#的函数就是方法 表示一堆可以重复利用的函数
        //要求输入值-参数  执行结果-返回值

        //函数语法 
        /*
        public static 返回值类型（不需要返回值则写void；需要的话要的时候还要写个接收） 方法名([参数列表])——public 访问修饰符 公开公共表示哪儿都可以访问  static静态的 方法名需要符合命名规范 参数列表为方法所须条件，不需要不能省略小括号
        {
            方法体;
        }

        //最好找的例子
        static void Main(string[] args)
        */


        /// <summary>
        /// 计算两个整数最大值并返回
        /// </summary>
        /// <param name="n1">第一个参数</param>
        /// <param name="n2">第二个参数</param>
        /// <returns>返回最大值</returns>
        //练习1-计算两个整数最大值
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;//三元表达式 return表示返回值并立即结束本方法
        }
        

        static void Main(string[] args)
        {
            //方法的调用
            ///////////类名.方法名([参数]);
            int maxx = Program.GetMax(1, 4);//有返回值需要接收
            Console.WriteLine(maxx);
            Console.ReadKey();
            //如果方法和Main()函数在同一个类（Program）中,可以省略类名；其他类似Console.WriteLine不能省略类名Console

            int b = 10;
            int a = 7;
            Test(a);
            Console.WriteLine(a);
            Console.ReadKey();

            bool byear = RunYear(2000);//省略了Program
            Console.WriteLine(byear);
            Console.ReadKey();

            Console.WriteLine("Input a num:");
            string numdep = Console.ReadLine();
            int res = NumDep(numdep);
            Console.ReadKey();

            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int sum = NBSUM(nums);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
       
        
        //private（默认）： 仅在同一类中可访问。
        //public： 可以在任何地方访问，包括其他类和程序集。
        static void Test(int a)//1. 传递参数
        {
            a += 5;//没有返回值则不影响外部         
        }
        public static int _number = 10;//2. 使用静态字段来模拟全局变量(范围:整个Program类) 它不是方法

        /*
       我们在Main()函数中调用Test()函数 则Main()函数称为调用者，Test()为被调用者
       [被调用者需要得到调用者的值有两种方法：]
        1. 传递参数
        2. 使用静态字段来模拟全局变量(好处：不用多次传参数
         */


        /// <summary>
        /// 判断是否是闰年
        /// </summary>
        /// <param name="year">给定年份</param>
        /// <returns>是不是闰年</returns>
        public static bool RunYear(int year)
        {
            bool b = (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
            return b;
        }

        //方法的功能一定要单一，最忌讳提示用户输入（因为输入仅限控制台）
        public static int NumDep(string num)
        {
            while (true)
            {
                try
                {
                    int n = Convert.ToInt32(num);
                    Console.WriteLine("YEP!");
                    return n;
                }
                catch (Exception)
                {
                    Console.WriteLine("Again:");
                    num = Console.ReadLine();
                    
                }
            }
        }

        public static void YNDep(string yn)
        {
            while (true)
            {
                if (yn=="yes"||yn=="no")
                {
                    Console.WriteLine("YEP!");
                }
                else
                {
                    Console.WriteLine("Again:");
                    yn = Console.ReadLine();
                }
            }
        }

        public static int NBSUM(int[] nba)
        {
            int sum = 0;
            for (int i = 0; i < nba.Length; i++)
            {
                sum += nba[i];
            }
            return sum;
        }
    }
}
