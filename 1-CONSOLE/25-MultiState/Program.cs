using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_MultiState
{
    class Program
    {
        static void Main(string[] args)
        {
            ////多态：让一个对象表现出多种状态(类型)
            ////Person[] per = new Person[3];
            //Student amy = new Student("Amy");
            //Student bob = new Student("Bob");
            //Teacher ProfCINCYA = new Teacher("Cyncia");
            //Person[] per = { amy, bob, ProfCINCYA };//表现出来都是父类 

            //for (int i = 0; i < per.Length; i++)
            //{
            //    //    if (per[i] is Student)没有多态时需要的
            //    //    {
            //    //       ((Student)per[i]).SayHi();
            //    //    }
            //    //    else if (per[i] is Teacher)
            //    //        {
            //    //            ((Teacher)per[i]).SayHi();
            //    //        }
            //    //    else
            //    //    {
            //    per[i].SayHi();
            //}
            ////}


            ////实现多态的三种方法
            ////1. 虚方法（知道写什么内容：父类方法有默认实现，父类需要被实例化）
            /////1-1将父类标注为虚方法：在父类中将方法声明为 virtual
            /////1-2用子类将函数重写：在子类中使用 override 进行重写。这样，运行时会根据对象的实际类型调用相应的方法。

            ////2.抽象类（不知道写什么内容：父类方法没有默认实现，父类不需要被实例化）
            /////当父类方法不知道如何实现的时候，可以考虑将父类写成抽象类   声明为 abstract
            /////抽象类不允许创建对象            抽象方法必须在抽象类中
            ////两方法可以共存

            //练习1 母鸡咕咕 公鸭嘎嘎
            Animal[] ans = { new Chick("Chicken"), new Duch("Drake") };
            //for (int i = 0; i < ans.Length; i++)
            //{
            //    ans[i].Yell();
            //}

            ////练习2 面积周长
            //Shape[] sp = { new Square(10), new Circle(10) };
            //for (int i = 0; i < sp.Length; i++)
            //{
            //    double a = sp[i].Area();
            //    double b = sp[i].Peri();
            //    Console.WriteLine("面积{0:F2}，周长{1:F2}", a, b);
            //}


            ////练习3 模拟计算机读取数据
            //Removable_Storage[] rs = { new MP3(), new Thumb_drive() };
            //Computer cm = new Computer();
            //for (int i = 0; i < rs.Length; i++)
            //{
            //    cm.CpuRead(rs[i]);
            //    cm.CpuWrite(rs[i]);
            //}

            //Removable_Storage ms = new MP3();
            //cm.CpuRead(ms);


            ////3. 接口-功能-比如有的会有的不会  //显示实现接口解决方法重名
            IFlyable fly = new Chick("Chicken");
            fly.Fly();//接口的fly
            Chick ck = new Chick("Cock");
            ck.Fly();//base类的fly
            Console.ReadKey();
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i].Yell();
                try
                {
                    ans[i].Fly();
                }
                catch (Exception)
                {

                    ans[i].Swim();
                }
            }
        }


    }
}
