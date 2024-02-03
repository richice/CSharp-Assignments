using System;
using System.Collections;

namespace _19_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ////创建一个集合对象
            ////集合：很多数据的一个集合 长度可变，类型随便（里氏转换）
            ////数组：长度不可变，类型单一
            //ArrayList list = new ArrayList();
            ////count 集合中实际包含元素数
            ////capacity 集合容量-可以包含元素数 满了会向内存申请再给我开一倍4*N


            ////添加
            //list.Add(1);
            //list.Add('男');
            //list.Add(new int[] { 1, 2, 3, 4, 5, 6, 7 });//叠加添加 添加单个
            //list.Add(new Person());//默认打印的是对象所在类的命名空间 
            
            //list.AddRange(new int[] { 8,9 });//顺序添加 添加集合
            //list.Add(list);

            //list.Insert(1, "nihao");//指定位置插入
            //list.InsertRange(1, new int[] { 10, 11 });//指定位置插入集合(Collection)


            ////list.Clear()删除所有
            //list.Remove(1);//删除单个 写啥删啥
            //list.Remove(0);//根据下标删
            //list.RemoveRange(0, 3);//根据下标范围删

            ////list.Sort();//不能比较会报错
            //list.Reverse();//反转

            //bool b = list.Contains(1);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] is Person)
            //    {
            //        ((Person)list[i]).SayHi();
            //    }
            //    else if (list[i] is int)
            //    {
            //        Console.WriteLine(list[i].ToString());
            //    }
            //    else if (list[i] is string)
            //    {
            //        Console.WriteLine(list[i]);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}



            ////练习1 平均求和
            //ArrayList test = new ArrayList();
            //test.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            //int sum = 0;
            //for (int i = 0; i < test.Count; i++)
            //{
            //    //sum += Convert.ToInt32(test[i]);
            //    sum += (int)test[i];
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(sum / test.Count);

            //练习2 随机十个不重复
            ArrayList numori = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                numori.Add(i);
            }
            Random r = new Random();
            
            ArrayList num = new ArrayList();
            while (true)
            {
                int rnum = r.Next(0, 10);
                if (numori.Contains(rnum))
                {
                    numori.Remove(rnum);
                    num.Add(rnum);//法1             法2反过来 加的时候看里面contain不 限定i<10;已有的就i--加回来机会
                    Console.WriteLine(rnum);
                }
                else if (numori.Count==0)
                {
                    break;
                }
            }
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
