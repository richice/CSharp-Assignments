using System;

namespace _04_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Input!");
            //string str = Console.ReadLine();
            //Console.WriteLine("Your input is " + str);
            //Console.ReadKey();


            ////练习1-input
            //Console.WriteLine("Hotties, what fruit does you like?");
            //string str2 = Console.ReadLine();
            //Console.WriteLine("No way! I am also a big fan of " + str2+"!");
            //Console.ReadKey();


            ////练习2
            //Console.WriteLine("Hotties, what is your name?");
            //string str3 = Console.ReadLine();
            //Console.WriteLine("Hotties, what is your age");
            //string str4 = Console.ReadLine();
            //Console.WriteLine("Hotties, what is your gender");
            //string str5 = Console.ReadLine();
            //Console.WriteLine("Your are " + str3 + " and are "+str4+" years old, "+str5);
            //Console.ReadKey();


            ////练习3-转义符
            //string str6= "Hello\nNice to see you\t ICE"//现在windows也可识别\n
            //Console.WriteLine(str6);
            //Console.ReadKey();
            //System.IO.File.WriteAllText(@"C:\Users\ICE\Desktop\C-sharpe Navigator.txt", str6);//
            //Console.WriteLine("Done");
            //Console.ReadKey();


            ////练习4-运算
            //int chinese = 90;
            //int math = 80;
            //int english = 67;
            //Console.WriteLine("总成绩{0}，平均分{1}", chinese + math + english, (chinese + math + english) / 3);
            //Console.ReadKey();

            //double s = 3.14 * 5 *5;
            //double c = 3.14 *5 * 2;
            //Console.WriteLine("面积是{0}，周长是{1}", s, c);
            //Console.ReadKey();

            //int tsh = 35;
            //int tro = 120;
            //int total = 3 * tsh + 2 * tro;
            //Console.WriteLine("总价{0}，折后{1:0.00}", total, total * 0.88);//:0.00表示留两位小数
            //Console.ReadKey();


            ////HW1-计算几天是几周
            //Console.WriteLine("请输入天数：");
            //string input = Console.ReadLine();

            //// 尝试将输入转换为整数
            //if (int.TryParse(input, out int days))
            //{
            //    int weeks = days / 7; // 计算周数
            //    int remainingDays = days % 7; // 计算剩余的天数

            //    Console.WriteLine($"{days}天是{weeks}周，多{remainingDays}天。");// $ 放在字符串的开头可以创建一个插值字符串，允许在字符串中嵌入变量或表达式，如 var name = "Alice"; var greeting = $"Hello, {name}!";。
            //}
            //else
            //{
            //    Console.WriteLine("输入不是有效的数字，请重新输入！");
            //}


            ////HW2-计算几秒是几时几分
            ////Way1
            //Console.WriteLine("请输入秒数：");
            //string sec = Console.ReadLine();
            //if (int.TryParse(sec, out int secs))
            //{
            //    int minu=secs/60;
            //    int minus = minu % 60;
            //    int hours = minu / 60;
            //    int remainsec = secs % 60;

            //    Console.WriteLine($"{secs}秒是{hours}时{minus}分{remainsec}秒.");
            //}
            //else
            //{
            //    Console.WriteLine("TypeError!");
            //}
            ////Way2

            //try
            //{
            //    int sec2 = Convert.ToInt32(sec);
            //    int hours2 = sec2 / 3600; // 计算小时数
            //    int remainMin = (sec2 % 3600) / 60; // 计算剩余分钟数
            //    int remainSec = sec2 % 60; // 计算剩余秒数

            //    Console.WriteLine($"{sec2}秒是{hours2}时{remainMin}分{remainSec}秒.");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("TypeError!");
            //}


            //练习5-输入
            Console.WriteLine("Input a number:");

            //string num = Console.ReadLine();
            //int n = Convert.ToInt32(num);
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n * 2);
            Console.ReadKey();

        }
    }
}
