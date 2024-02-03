using System;

namespace _13_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数字1:");
            string a = Console.ReadLine();
            int aa = GetNum(a);
            Console.WriteLine("OK-数字1:" + aa);
            Console.WriteLine("数字2:");
            string b = Console.ReadLine();
            int bb = GetNum(b);
            Console.WriteLine("OK-数字2:" + bb);

            int c = GetSum(ref aa, ref bb);
            Console.WriteLine("数字总和:" + c);



            string[] lon = { "amy", "lily", "mack", "jijiya" };
            string forlon = GetLong(lon);
            Console.WriteLine("Max length:" + forlon);


            Console.WriteLine("数字:");
            a = Console.ReadLine();
            aa = GetNum(a);
            bool zhishu = DecZhi(aa);
            Console.WriteLine("zhishi?" + zhishu);


            double r = 5;
            double cc, ss;
            circle(r, out cc, out ss);
            Console.WriteLine("peremeter of this circle(r={0})?:{1}",r,cc);



            Console.ReadKey();
        }






        public static int GetNum(string a)
        {
            while (true)
            {
                try
                {
                    int aa = Convert.ToInt32(a);
                    return aa;
                }
                catch (Exception)
                {
                    Console.WriteLine("不是数字，再输入：");
                    a = Console.ReadLine();
                }
            }
        }

        public static int GetSum(ref int aa,ref int bb)//把变化带出去-REF
        {
            while (true)
            {
                if (aa < bb)
                {
                    return aa + bb;
                }
                else
                {
                    Console.WriteLine("要求第一个数字必须比第二个小。再输入数字1:");
                    string a = Console.ReadLine();
                    aa = GetNum(a);
                    Console.WriteLine("数字1:" + aa);
                    Console.WriteLine("数字2:");
                    string b = Console.ReadLine();
                    bb = GetNum(b);
                    Console.WriteLine("数字2:" + bb);
                }
            }
        }



        public static string GetLong(string[] a)
        {
            string maxx = a[0];
            //int forlon = a[0].Length;
            
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i].Length> maxx.Length)
                {                    
                    maxx = a[i];
                }
            }

            return maxx;
        }

        public static bool DecZhi(int dezhi)
        {
            int count = 0;
            bool reszhi = true;
            
            if (dezhi<2)
            {
                reszhi = false;
            }
            
            for (int i = 1; i < dezhi; i++)
            {
                if (dezhi%i==0)
                {
                    count++;
                }
            }

            if (count>1)
            {
                reszhi= false;
            }

            return reszhi;
        }

        public static string DecRank(int score)
        {
            //if (100>grade&&grade>=90)
            //{
            //    return "优秀";
            //}
            //else if (90 > grade && grade >= 80)
            //{
            //    return "良好";
            //}
            //else if (80 > grade && grade >= 70)
            //{
            //    return "合格";
            //}
            //else
            //{
            //    return "不合格";
            //}

            switch (score/10)
            {
                case 10:
                case 9: return "优秀";
                case 8:
                case 7: return "良好";
                case 6: return "合格";
                default:
                    return "不合格";
            }
        }

        public static void circle(double r, out double c, out double s)
        {
            c = 2 * 3.14 * r;
            s = 3.14 * r * r;
        }

        public static int GetMax(params int[] numbers)//把变化带出去-REF
        {
            int[] sortedNumbers = (int[])numbers.Clone(); // 创建原始数组的副本  
            Array.Sort(sortedNumbers);//否则这样会修改传递给方法的原始数组
            return sortedNumbers[sortedNumbers.Length - 1];
        }


    }
}
