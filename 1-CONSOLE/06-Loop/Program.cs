using System;

namespace _06_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region whileLoop

            ////习题1 - 打印100编 - While循环
            //int i = 0;
            //while (i < 100)//循环条件
            //{
            //    Console.WriteLine("Meeting Offer多多\t{0}", i);//循环体
            //    i++;
            //}
            //Console.ReadKey();

            ////习题2-求和1到100累加-While循环
            //int i = 1;
            //int s = 0;
            //while (i <= 100)
            //{
            //    s += i;
            //    i++;
            //}
            //Console.WriteLine(s);
            //Console.ReadKey();

            ////习题3 - 密码
            //Console.WriteLine("账号");
            //string name;
            //string password;
            ////用于跟踪用户是否已经成功验证
            //bool isAuthenticated = false;

            ////只要用户尚未成功验证，就继续循环
            //while (!isAuthenticated)
            //{
            //    name = Console.ReadLine();
            //    Console.WriteLine("密码");
            //    password = Console.ReadLine();

            //    //检查账号和密码是否正确
            //    if (name == "admin" && password == "888888")
            //    {
            //        Console.WriteLine("PASS");
            //        isAuthenticated = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("WRONG");
            //        Console.WriteLine("账号");
            //    }
            //}
            //Console.ReadKey();

            ////作业1- 录入成绩
            //Console.WriteLine("People?");
            //int ppl = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //while (i <= ppl)
            //{
            //    Console.WriteLine("第{0}人的分数", i);
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    i++;
            //    sum += score;
            //}
            //double aver = (double)sum / ppl;
            //Console.WriteLine("{0}人的总分{1}，平均分{2:F2}", ppl, sum, aver);
            //Console.ReadKey();
            ////错误：while后面不应有分号，总人数是ppl，除法结果保留小数，异常处理

            ////作业2- 最强大脑
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Can you? yes/no");
            //    string ans = Console.ReadLine();
            //    if (ans == "yes")
            //    {
            //        break;
            //    }
            //    i++;
            //}
            //Console.ReadKey();

            ////作业3- 利滚利
            //double ppl = 80000;
            //int year = 2006;
            //while (ppl < 200000)
            //{
            //    ppl *= 1.25;
            //    year++;
            //}
            //Console.WriteLine("{0}年可有{1:F2}", year, ppl);
            //Console.ReadKey();

            ////习题4-循环-三次
            ////Console.WriteLine("输入yes或y：");多余
            //string ans = "";
            //int i = 1;
            //while ((ans != "yes" && ans != "y") && i < 3)
            //{
            //    Console.WriteLine("输入yes或y：");
            //    ans = Console.ReadLine();
            //    i++;
            //}
            //Console.ReadKey();


            ////习题5-账户 - doWhile循环
            //string a = "";
            //while (a == "")
            //{
            //    Console.WriteLine("a=");
            //    a = Console.ReadLine();
            //}
            //Console.WriteLine("b=");
            //string b = "";
            //do
            //{
            //    Console.WriteLine("b=");
            //    b = Console.ReadLine();
            //} while (b == a || b == "");
            //Console.ReadKey();



            ////习题1 - 登录 - doWhile循环
            //string userName = "";
            //string userPass = "";
            //do
            //{
            //    userName = Console.ReadLine();
            //    Console.WriteLine("账号");
            //    userPass = Console.ReadLine();
            //    Console.WriteLine("密码");
            //} while (userName != "admin" && userPass != "8888");
            //Console.ReadKey();

            ////习题2 - 输入数字两倍 输入q结束

            //string input;
            //do
            //{
            //    Console.WriteLine("input:");
            //    input = Console.ReadLine();

            //    if (input == "q")
            //    {
            //        break;
            //    }

            //    try
            //    {
            //        double a = Convert.ToDouble(input);
            //        Console.WriteLine(a * 2);

            //    }
            //    catch
            //    {
            //        Console.WriteLine("input:");
            //    }
            //}
            //while (true);
            //Console.ReadKey();

            ////习题3 - 最大值 - While

            //try
            //{
            //    int max = 0;
            //    string inp;

            //    while (true)
            //    {

            //        Console.WriteLine("input(q=end)");
            //        inp = Console.ReadLine();
            //        if (inp == "q")
            //        {
            //            break;
            //        }
            //        int inpt = Convert.ToInt32(inp);
            //        do
            //        {
            //            max = inpt;
            //        } while (max < inpt);
            //    }

            //}
            //catch
            //{
            //    Console.WriteLine("不是数字？");
            //}
            //Console.ReadKey();
            #endregion

            #region forLoop

            ////习题一  99乘法表

            //for (int i = 1; i <= 9; i++)//tab两下出格式
            //{
            //    //string li = "";
            //    for (int j = 1; j < 10; j++)//一个j tab一下自动改后两个
            //    {
            //        //    li = li + i + "*" + j + "=" + i * j + "\t";            
            //        //}
            //        //Console.WriteLine(li);默认换行
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);//默认不换行
            //    }
            //    Console.WriteLine();//换行
            //}
            //Console.ReadKey();


            ////习题二  半99乘法表

            //for (int i = 1; i <= 9; i++)//tab两下出格式
            //{
            //    //string li = "";
            //    for (int j = 1; j <=i; j++)//一个j tab一下自动改后两个
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);//默认不换行
            //    }
            //    Console.WriteLine();//换行
            //}
            //Console.ReadKey();


            ////习题三  加法凑数表
            //Console.WriteLine("INPUT:");
            //try
            //{
            //    int j = Convert.ToInt32(Console.ReadLine());

            //    for (int i = 0; i <= j; i++)//tab两下出格式
            //    {
            //        Console.WriteLine("{0} + {1} = {2}", i, j-i, j);
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}


            ////作业1-循环录入五个年龄算平均，复数或大于120报错
            //int sum = 0;
            //bool b = true;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("输入第{0}个年龄:", i);
            //    int j = Convert.ToInt32(Console.ReadLine());
            //    if (j >= 0 && i <= 120)
            //    {
            //        sum += i;
            //    }
            //    else
            //    {
            //        Console.WriteLine("第{0}个年龄报错", i);
            //        b = false;
            //        break;
            //    }
            //}
            //if (b)
            //{
            //    Console.WriteLine("年龄平均值{0}", sum / 5);
            //}
            //Console.ReadKey();


            ////作业2-循环录入账号密码
            //string admin = "";
            //string passw = "";

            //法一
            //do
            //{
            //    Console.WriteLine("输入账号:");
            //    admin = Console.ReadLine();
            //    Console.WriteLine("输入密码");
            //    passw = Console.ReadLine();
            //    if (admin != "admin" || passw != "88888")
            //    {
            //        Console.WriteLine("AGAIN");
            //    }
            //    else
            //    {
            //        Console.WriteLine("DONE");
            //    }
            //} while (admin != "admin" || passw !="88888");     

            //法二 死循环
            //while (true)
            //{
            //    Console.WriteLine("输入账号:");
            //    admin = Console.ReadLine();
            //    Console.WriteLine("输入密码");
            //    passw = Console.ReadLine();
            //    if (admin != "admin" || passw != "88888")
            //    {
            //        Console.WriteLine("AGAIN");
            //    }
            //    else
            //    {
            //        Console.WriteLine("DONE");
            //        break;
            //    }
            //}

            //Console.ReadKey();


            ////作业3 1-100累加 大于20则输出
            //int sum = 0;
            //for (int i = 1; i < 100; i++)
            //{
            //    sum += i;
            //    if (sum>20)
            //    {
            //        Console.WriteLine("i");
            //        break;
            //    }
            //}
            //Console.ReadKey();


            ////练习1 实现计算1到100（含）之间的除了能被7整除之外所有整数的和
            //int sum = 0;
            //for (int i = 1; i < 101; i++)
            //{
            //    while (i%7!=0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("sum={0}",sum);
            //Console.ReadKey();

            //练习2
            int i = 2;
            while (i < 101)
            {
                int ci = 0;
                for (int j = 1; j < i; j++)
                { 
                    if (i%j ==0)
                    {
                        ci++;                      
                    }
                }

                if (ci==1)
                {
                    Console.Write("{0}\t", i);                    
                }
                i++;
            }
            Console.ReadKey();



            #endregion





        }
    }
}
