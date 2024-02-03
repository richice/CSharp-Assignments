using System;

namespace _08_Enumeration
{
    public enum Gender
    {
        男=8,//从8开始
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强转成int类型
            //Gender gender = Gender.男;
            //int n = (int)gender;
            //Console.WriteLine(n);

            //Console.WriteLine((int)Gender.女);
            //Console.ReadKey();
            #endregion

            #region 将int类型强转成枚举类型
            //int n = 8;
            //Gender gender = (Gender)n;

            //Console.WriteLine(gender);
            //Console.ReadKey();
            #endregion

            #region 将枚举类型强转成str类型

            ////int n = 8;
            ////string s = n.ToString();

            //Gender g = Gender.男;
            //Console.WriteLine(g.ToString());
            //Console.ReadKey();
            #endregion

            //练习1
            Console.WriteLine("输入性别 8-男 9-女");
            string input = Console.ReadLine();
            //switch (input)
            //{
            //    case "8": Gender gender1 = (Gender)Enum.Parse(typeof(Gender), input);//声明接收 拿到input类型 然后转化
            //        Console.WriteLine("性别是{0}", gender1);
            //        break;
            //    case "9": Gender gender2 = (Gender)Enum.Parse(typeof(Gender), input);
            //        Console.WriteLine("性别是{0}", gender2);
            //        break;
            //}
            Gender gender = (Gender)Enum.Parse(typeof(Gender), input);
            Console.WriteLine("性别是{0}", gender);
            Console.ReadKey();
        }

    }   
}
