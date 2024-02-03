using System;

namespace _10_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组可以存储(类型相同的)多值
            //数组类型[] 数组名=new 数组类型[数组长度];——数组长度一旦确定就不能改变
            int[] nums = new int[10];

            //数组声明方式 推荐2
            int[] nums2 = { 1, 2, 3, 4, 5 };
            int[] nums3 = new int[3] { 1, -2, 3 };
            int[] nums4 = new int[] { 1, -2, 3 };


            #region 取值练习
            //练习1-取出数组中最大、最小、总和、平均
            int max = nums2[0];//法二：int.MaxValue 最大的int
            int min = nums2[0];//法二：int.MinValue
            int sum = 0;
            for (int i = 1; i < nums2.Length; i++)
            {
                sum += i;
                if (nums2[i] > max)
                {
                    max = nums2[i];
                }
                else
                {
                    min = nums2[i];
                }
            }
            Console.WriteLine("最大值{0}，最小值{1}，总和{2}，平均{3}", max, min, sum, sum / nums2.Length);
            Console.ReadKey();
            #endregion

            #region 分隔练习
            string[] names = { "Amu", "Beec", "Cacy" };
            string str = null;//null不开空间 “”开空间
            for (int i = 0; i < names.Length-1; i++)
            {
                str += names[i] + "|";
            }
            Console.WriteLine(str+names[names.Length - 1]);
            Console.ReadKey();
            #endregion

            #region 判断练习
            for (int i = 0; i < nums3.Length; i++)
            {
                if (nums3[i] > 0)
                {
                    nums3[i]++;
                }
                else if (nums3[i] < 0)
                {
                    nums3[i]--;
                }
                Console.Write(nums3[i] + " ");
            }
            Console.ReadKey();
            Console.WriteLine();
            #endregion

            #region 反转练习            
            for (int i = 0; i < nums4.Length/2; i++)
            {
                int inter = nums4[nums4.Length - i - 1];
                Console.Write(inter+" ");
            }            
            Console.ReadKey();
            #endregion

            #region 冒泡练习
            //for (int i = 0; i < nums4.Length-1; i++)//拿第一个和剩下所有比大小
            //{
            //    for (int j = 0; j < nums4.Length-1-i; j++)//拿头一个渐渐和剩下所有比大小，减少重复
            //    {
            //        if (nums4[j]<nums4[j+1])//升序
            //        {
            //            int inter = nums4[j];
            //            nums4[j] = nums4[j + 1];
            //            nums4[j + 1] = inter;
            //        }
            //    }
            //} 

            Array.Sort(nums4);//简洁方法=只能升序-比大小
            Array.Reverse(nums4);//倒叙反转-只看位置
            #endregion
        }
    }
}
