using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Static
{
    class Class1 //无static:非静态类
    {        
        //静态函数（M2）中只能访问静态成员，不允许访问实例成员
        public static void M2()
        {
            Console.WriteLine("这是静态方法");
        }

        //实例方法（M1）中都可以
        public void M1()//实例成员=非静态成员
        {
            Console.WriteLine("这是非静态方法");
        }
    }
}
