using System;

namespace _16_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 字段：存储数据 _age
             * 属性：保护字段，限定取值和设值  属性的本质就是两个方法set get(里面判断字段)——可限定
             * 方法：描述对象的行为
             * 构造函数：初始化对象（给对象的每个属性依次赋值——可限定
             *      1.没有返回值甚至void
             *      2.名字和类名一样
             * this:当前类的对象 or 在类当中显示的调用本类的构造函数
             * new:1.内存中开辟空间 2.空间中创建对象 3.调用当前类的构造函数（可以重载）
             */


            Class1 p = new Class1();//new:1.内存中开辟空间 2.空间中创建对象 3.调用对象的构造函数（可以重载）进行初始化对象

            p.M1();            //调用实例成员 需要使用对象名.实例成员()            静态类在整个项目中资源共享
            Class1.M2();       //调用静态成员 需要使用类名.对象成员名()            用类名所以不需要创建对象  用法：工具类 例如console


            Student susu = new Student("苏苏",18,'女',100,100);
            //susu.Name = "苏苏";
            //susu.Age = 18;
            //susu.Gender = '女';
            //susu.Chinese = 100;
            //susu.Math = 100;
            susu.ShowScore();

            //构造函数=构造一种特殊的方法 1.函数没有返回值，也不能写void   2.构造函数的名称必须和类名一样
            Student koko = new Student("可可", 28, '女', 100, 100);
            susu.ShowScore();


            Ticket yuquan = new Ticket(90);
            yuquan.ShowInf();
            Console.ReadKey();
        }
    }
}
