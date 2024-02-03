using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Inherit
{
    public class Student : Person
    {
        public Student(string name, int age, char gender, int chinese, int math) : base(name, age, gender)//通过调用 base(name, age, gender) 初始化共享属性，然后通过直接对 _chinese 和 _math 赋值初始化子类自己的属性。
                                                                                                          //这是因为在构造函数中，直接对字段赋值可以绕过属性的逻辑，而在这里可能是为了避免属性逻辑的干扰或者因为直接赋值更为简洁。
        //Name、Age、Gender、Chinese、Math 都是属性，而 _chinese 和 _math 是对应的私有字段。
        //属性的命名通常采用首字母大写的驼峰命名法，而私有字段则使用下划线前缀。
        {
            _chinese = chinese;//这在构造函数中使用属性的目的可能是为了执行属性的 set 访问器中的逻辑，而直接对私有字段赋值则是在不经过属性逻辑的情况下设置字段的值。
            _math = math;
        }

        //private int _chinese;//表示声明了私有整数型字段 只能在当前类内部访问
        protected  int _chinese;//只能在当前类内部访问 权限更高
        public int Chinese
        {
            get { return _chinese; }//ctrl+r+e 快速导出
            set { _chinese = value; }
        }

        private int _math;
        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }

        public void ShowScore()
        {
            Console.WriteLine("{0}的语文成绩{1}，数学成绩{2}", Name, Chinese, Math);
        }

        public new void SayHi()
        {
            Console.WriteLine("HI!:>");
        }
    }
}
