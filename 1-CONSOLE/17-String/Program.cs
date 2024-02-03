using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace _17_String
{
    class Program
    {
        static void Main(string[] args)
        {
            ////string可以看作char的一个只读数组
            //string s = "abghjk";
            ////可以访问不能改
            //Console.WriteLine(s[0]);
            ////旧的不会删去 而是会开辟新空间 因此有大量垃圾
            //s = "tyuiolp";

            ////将string转换成可读的char数组
            //char[] c = s.ToCharArray();
            //c[0] = 'b';
            ////你操作
            //string s2 = new string(c);

            ////没开空间
            //StringBuilder sb = new StringBuilder();
            //string str = null;
            ////创建计时器 记录程序运行的时间
            //Stopwatch sw = new Stopwatch();
            //sw.Start();//开始计时
            //for (int i = 0; i < 1000000; i++)
            //{
            //    //str += 1;
            //    sb.Append(i);
            //}
            //sw.Stop();//结束计时
            ////Console.WriteLine(sb.ToString());//转换成字符串
            //Console.WriteLine(sw.Elapsed);//输出计时


            ////练习1字符串长度
            //Console.WriteLine("Input:");
            //string cal = Console.ReadLine();
            //Console.WriteLine(cal.Length);


            ////练习2字符串判断
            //Console.WriteLine("Input1:");
            //string cal1 = Console.ReadLine();
            //cal1 = cal1.ToUpper();//转大写
            //Console.WriteLine("Input2:");
            //string cal2 = Console.ReadLine();
            ////if (cal1==cal2)
            //if (cal1.Equals(cal2, StringComparison.OrdinalIgnoreCase))//在比较时忽略大小写
            //{
            //    Console.WriteLine("OK");
            //}
            //else
            //{
            //    Console.WriteLine("不OK");
            //}


            ////练习3分割字符串
            //string cal = "    a  h  s   dgwbu  +  ,,,w dhwh      ";
            //char[] chs = { ' ', '+', ',', '-' };
            //string[] call = cal.Split(chs, StringSplitOptions.RemoveEmptyEntries);//摘去空壳

            //string date = "2008-08-08";
            //string[] datenew = date.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日", datenew[0], datenew[1], datenew[2]);

            //string[] name = { "A", "B", "C" };
            //string strNew = string.Join("|", name);//用于连接的字符串，需要连接的数组
            //Console.WriteLine(strNew);

            ////练习4关键字提取
            //string str1 = "国家领导人帅冰";
            //if (str1.Contains("国家领导人"))
            //{
            //    str1 = str1.Replace("国家领导人", "OFFER多多多");
            //}
            //Console.WriteLine(str1);

            //string str2 = str1.Substring(0, 5);
            //Console.WriteLine(str2);

            //if (str1.StartsWith("OFFER多多多"))
            //{
            //    Console.WriteLine("必须的");
            //}

            //int index = str1.IndexOf("冰", 3);//判断第一次出现的位置 -1表示找不到            
            //Console.WriteLine(index);

            //string path = @"C:\Users\ICE\Downloads\diffusion_policy_vision_nail_demo.py";
            //int lastindex = path.LastIndexOf("\\");//最后一次出现的位置 转义
            //path = path.Substring(lastindex);//截取字符串 包括这个数本身
            //Console.WriteLine(path);

            //string cal1 = cal.Trim();//剪两边
            //string cal2 = cal.TrimStart();//只剪开头
            //Console.WriteLine(cal1);


            //作业1 倒叙循环
            //Console.WriteLine("Input:");
            //string s = Console.ReadLine();
            //char[] c = s.ToCharArray();
            //for (int i = 0; i < s.Length/2; i++)
            //{
            //    char temp = c[i];
            //    c[i] = c[s.Length-1- i];
            //    c[s.Length-1] = temp;
            //}
            //s = new string(c);
            //Console.WriteLine(s);

            //string s = "ss ss cc ss";
            //char[] c = { ' ' };
            //string[] snew = s.Split(c, StringSplitOptions.RemoveEmptyEntries);
            //string s2 = "";
            //for (int i = snew.Length-1; i >=0; i--)
            //{
            //    //string temp = snew[i];
            //    //snew[i] = snew[s.Length - 1 - i];
            //    //snew[s.Length - 1] = temp; 法一 倒叙然后用join
            //    s2 += snew[i] + " ";       //法二 
            //}
            //Console.WriteLine(s2);


            ////作业2 提取邮箱
            //string qq = "22112@qq.com";
            ////char[] c = { '@' };       //法一 拆开； 法二 indexof@然后substring
            //string[] qqnew = qq.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("名称是{0}，域名是{1}", qqnew[0], qqnew[1]);

            ////作业3 书名排版
            //string path = @"F:\CODE\C#\01-My first demo\1.txt";
            //string[] content = File.ReadAllLines(path, Encoding.Default);

            //for (int i = 0; i < content.Length; i++)
            //{
            //    // 分割每行内容
            //    string[] columns = content[i].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            //    // 处理每一列，确保长度达到4
            //    for (int j = 0; j < columns.Length; j++)
            //    {
            //        columns[j] = columns[j].Length < 4
            //            ? columns[j] + new string(' ', (4 - columns[j].Length) * 2)  // 不足4的用空格填充
            //            : columns[j].Substring(0, 4);  // 截取前4个字符
            //    }

            //    // 将所有列连接起来，并在它们之间加入额外的空格
            //    string result = string.Join("    ", columns);
            //    Console.WriteLine(result);


            // 作业4 找出所有e
            string path = @"E:\CODE\C#\01-My first demo\1.txt";
            int index = path.IndexOf('e'); // 查找第一个 'e' 的索引
            Console.Write(index.ToString() + "  ");
                        
            while ((index = path.IndexOf('e', index + 1)) != -1)// 继续查找剩余的 'e' 索引
            {
                Console.Write(index.ToString() + "  ");
            }

            Console.ReadKey();




        }
    }
}
