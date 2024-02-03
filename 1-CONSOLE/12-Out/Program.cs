using System;

namespace _12_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法 求一个数组中的最大最小总和平均并返回为一个数组
            int[] nba = { 1, 2, 3, 4, 5, 6, 7, 8 };
            
            int[] nbare = ProNm(nba);
            for (int i = 0; i < nbare.Length; i++)
            {
                Console.Write(nbare[i] + " ");
                Console.WriteLine();
            }


            int max, min;
            int[] nbare2 = TestProNm(nba, out max, out min);//需要接收
            Console.WriteLine("Max: " + max);


            Console.WriteLine("NAME:");
            string admin = Console.ReadLine();
            Console.WriteLine("passWORD:");
            string passw = Console.ReadLine();
            string resw;//空碗接水
            bool res = LogIn(admin, passw, out resw);
            Console.WriteLine(resw);
     
            //自制Parse
            int num;
            bool b = int.TryParse("123", out num);
            Console.WriteLine(b);

            //互换数字
            int aa = 10;
            int bb = 20;
            Console.Write(aa);
            TranNum(ref aa, ref bb);
            Console.WriteLine("变成"+aa);
            Console.ReadKey();
        }



        /// <summary>
        /// 计算数组中的最大最小总和平均并返回为一个数组
        /// </summary>
        /// <param name="nba"></param>
        /// <returns></returns>
        public static int[] ProNm(int[] nba)
        {
            int[] nbares = new int[4];
            
            Array.Sort(nba);
            nbares[0] = nba[nba.Length - 1];
            nbares[1] = nba[0];

            nbares[2] = 0;
            for (int i = 0; i < nba.Length; i++)
            {
                nbares[2] += nba[i];
            }

            nbares[3] = nbares[2] / nba.Length;

            return nbares;
        }


        //返回多个相同类型的值可以返回数组
        //不同类型则可以考虑Out参数
        /// <summary>
        /// 返回一个数组中的最大最小总和平均；最大最小
        /// </summary>
        /// <param name="nba"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static int[] TestProNm(int[] nba, out int max, out int min)//out参数在方法内部必须赋值，外部可以不定义赋值
        {
            int[] nbares = new int[4];

            Array.Sort(nba);
            nbares[0] = nba[nba.Length - 1];
            nbares[1] = nba[0]; nbares[2] = 0;
            for (int i = 0; i < nba.Length; i++)
            {
                nbares[2] += nba[i];
            }

            nbares[3] = nbares[2] / nba.Length;


            max = nba[nba.Length - 1];
            min = nba[0];
            return nbares;
        }


        public static bool LogIn(string a, string b,out string res)
        {
            while (true)
            {
                if (a == "admin" && b=="8888")
                {
                    res="OK";
                    return true;
                }  
                else if (a != "admin" && b == "8888")
                {
                    res = "用户名错误";
                    return false;
                }
                else if (a == "admin" && b != "8888")
                {
                    res = "密码错误";
                    return false;
                }
                else
                {
                    res = "用户名密码错误";
                    return false;
                }
            }
        }

        public static bool MyTryParse(string a, out int resnum)
        {
            try
            {
                resnum = Convert.ToInt32(a);
                return true;
            }
            catch (Exception)
            {
                resnum = 0; // 设置默认值
                return false;
            }
        }

        public static void TranNum(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
