using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _15_Class
{
    class Program
    {
        static void Main(string[] args)//结构面向过程[不太用]，类（封装，继承，多态）面向对象             结构也叫结构类，但是他不能被继承
        {            
            //Person susan = new Person();//创建Person类的对象susan      ——类不占内存因为都是None，对象占内存（有字段，字段有初值）
            //susan.Name = "susan";//给对象的每个属性赋值【对象的初始化】
            //susan.Age = 18;
            //susan.Gender ='女';//符号！
            //susan.CHLSS();




            //值类型： int double char decimal bool enum struct
            //引用类型： string数组 自定义类 集合 object 接口
            //值类型在栈上，引用类型是地址在栈上，但值在堆上
            //值类型复制的时候传递本身
            int n1 = 10;
            int n2 = n1;
            n2 = 10;
            Console.WriteLine("{0}和{1}",n1,n2);

            //引用类型复制的时候传递引用（传递后共用一个地址）
            Person p1 = new Person();
            p1.Name = "a1";
            Person p2 = p1;
            p2.Name = "A2";
            Console.WriteLine(p1.Name);//A2
            //更数组一样，可以直接传进来进行改变，不需要返回值_____1. 搭上关系之后牵一发而动全身  2.int等不能这样 需要加ref实现这个功能（ref把地址也传过去了）

            string s1 = "a1";
            string s2 = s1;
            s2 = "A2";
            Console.WriteLine(s1);//a1 字符串的不可变性：重新开辟空间_____string本身是特殊的常量


            //序列化：将对象转换成二进制  《-》反序列化
            //作用：传输数据
            //途径：1. 标注序列化[Serializable]
            Person susan = new Person();//创建Person类  的对象susan      ——类不占内存因为都是None，对象占内存（有字段，字段有初值）
            susan.Name = "susan";//给对象的每个属性赋值【对象的初始化】
            susan.Age = 18;
            susan.Gender = '女';//符号！
            susan.CHLSS();
            //using (FileStream FSW = new FileStream(@"F:\CODE\C#\01-My first demo\1.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    //2.开始序列化对象            
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(FSW, susan);
            //}
            //Console.WriteLine("成功");//a1 字符串的不可变性：重新开辟空间_____string本身是特殊的常量
            //3.接收二进制开始返序列化
            Person p;
            using (FileStream fsr = new FileStream(@"F:\CODE\C#\01-My first demo\1.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsr);
                p.CHLSS();
            }

                Console.ReadKey();





        }
    }
}
