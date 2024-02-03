using System;

namespace _18_Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student("susan",18,'女',12,22);
            //s.Name="susam";
            //s.ShowScore();

            ////里氏转换19-Richter transformation
            ////1.子类可以赋值给父类：如果一个地方需要父类作为参数 可以给子类替代
            ////Student s = new Student("susan",18,'女',12,22);
            //Person p = new Student("susan", 18, '女', 12, 22);

            ////例子：join需要的object是所有类的父类，但我们给子类替代
            //string str = string.Join("|", new string[] { 1, 2, 3, 4 });


            ////2.如果父类中装的是子类对象，那么可以将该父类强转为子类对象
            ////is的用法
            //if (p is Student)
            //{
            //    Student s = (Student)p;//Person类的P转成Student类
            //    s.SayHi();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            ////as的用法
            //Student s = p as Student;//能转换则给t 否则返回No ne
            //Console.WriteLine("转换失败");


            //练习1 随机打十个招呼
            Person[] pers = new Person[10];
            Random r = new Random();
            for (int i = 0; i <pers.Length; i++)
            {
                int rnum = r.Next(1, 3);//范围是 [1, 3)
                switch (rnum)
                {
                    case 1:
                        pers[i] = new Student("susan", 18, '女', 12, 22);//子类给父类赋值
                        if (pers[i] is Student)//父类类型里不能调用子类方法
                        {
                            Student s = (Student)pers[i];//Person类的P转成Student类
                            s.SayHi();
                        }
                        else
                        {
                            Console.WriteLine("转换失败");
                        }
                        break;
                    case 2:
                        pers[i] = new Teacher("susan", 18, '女', 33);
                        if (pers[i] is Teacher)
                        {
                            Teacher s = (Teacher)pers[i];//Person类的P转成Student类
                            s.TeacherSayHi();
                        }
                        else
                        {
                            Console.WriteLine("转换失败");
                        }
                        break;
                }
            }
            Console.ReadKey();
        }

    }

}
