using System;

namespace _05_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ////习题1-成绩单
            ////1）输入
            //Console.WriteLine("Chinese score:");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Music score:");
            //int m = Convert.ToInt32(Console.ReadLine());

            ////2）判断
            //bool b1 = c > 90 && m > 90;
            //bool b2 = c == 100 && m > 70;
            //if (b1 || b2)
            //{
            //    Console.WriteLine("Scholarship");
            //}

            //Console.ReadKey();

            ////习题2-闰年
            //Console.WriteLine("Year?:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //bool b1 = y % 400 == 0;//能够被400整除
            //bool b2 = y % 4 == 0;//能够被4整除
            //bool b3 = y % 100 != 0;//不能够被100整除
            //bool b = b1 || (b2 && b3) ;//先与&&再或||-优先级
            //Console.WriteLine(b);
            //Console.ReadKey();

            ////习题3-登录
            //Console.WriteLine("User:");
            //string a = Console.ReadLine();
            //Console.WriteLine("Password:");
            //string b = Console.ReadLine();
            //if (a == "admin" && b == "mypass")
            //{
            //    Console.WriteLine("Success");
            //}
            //Console.ReadKey();


            ////异常处理
            //Console.WriteLine("Year?:");
            //bool b0= true;
            //int y = 0;//声明一个变量
            //try
            //{
            //    y = Convert.ToInt32(Console.ReadLine());//赋值

            //}//变量的作用域在括号里，所以需要定义在外部
            //catch
            //{
            //    Console.WriteLine("没有输入数字");
            //    b0= false;
            //}        
            //if (b0)
            //{
            //    bool b1 = y % 400 == 0;//能够被400整除
            //    bool b2 = y % 4 == 0;//能够被4整除
            //    bool b3 = y % 100 != 0;//不能够被100整除
            //    bool b = b1 || (b2 && b3);//先与&&再或||-优先级
            //    Console.WriteLine(b);
            //}
            //Console.ReadKey();

            //习题4-年终奖            
            //Console.WriteLine("输入等级");
            //string level= Console.ReadLine();
            //switch (level)
            //{
            //    case "A":Console.WriteLine("+500");
            //        break;
            //    case "B":Console.WriteLine("+200");
            //        break;
            //    case "C":Console.WriteLine("+0");
            //        break;
            //    case "D":Console.WriteLine("-200");
            //        break;
            //    case "E":Console.WriteLine("-500");
            //        break;
            //    default: Console.WriteLine("这不是等级");
            //        break;
            //}

            ////习题5-算命
            //Console.WriteLine("Name?");
            //string name = Console.ReadLine();
            //switch (name)
            //{
            //    case "老杨": Console.WriteLine("羊");
            //        break;
            //    case "老牛": Console.WriteLine("牛");
            //        break;
            //    default: Console.WriteLine("这不知道");
            //        break;
            //}
            //Console.ReadKey();

            ////习题6-考试
            //Console.WriteLine("Score");
            //int score = Convert.ToInt32(Console.ReadLine());
            //switch(score/10)
            //{
            //    case 10: //重复一样可省略
            //    case 9 : Console.WriteLine("A");
            //        break;
            //    case 8:
            //        Console.WriteLine("B");
            //        break;
            //    case 7:
            //        Console.WriteLine("C");
            //        break;
            //    default:
            //        Console.WriteLine("F");
            //        break;
            //}


            //作业1-月份的天数-结合闰年思路
            Console.WriteLine("Year:");
            try 
            { int y = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Month:");
            int mon = Convert.ToInt32(Console.ReadLine());

            bool b1 = y % 400 == 0;//能够被400整除
            bool b2 = y % 4 == 0;//能够被4整除
            bool b3 = y % 100 != 0;//不能够被100整除
            bool b = b1 || (b2 && b3);//先与&&再或||-优先级

            
            switch (mon)
            {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("Day: 31");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("Day: 30");
                        break;
                    case 2:
                        if (b)
                        {
                            Console.WriteLine("Day: 28");
                        }
                        else
                        {
                            Console.WriteLine("Day: 29");
                        }
                        break;
                    default:
                        Console.WriteLine("这不是月份");
                        break;
            }
            Console.ReadKey();
            }

            catch
            {
                Console.WriteLine("这不是年份");
            }
        }

    }
}
