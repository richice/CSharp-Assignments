using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Static
{
    public class Student//静态类中只允许有静态成员 且不允许被实例化（创建对象）
    {
        public Student(string name,int age, char gender, int chinese, int math)
            //构造函数
        {
            this.Name = name;//this关键字：代表当前类的对象 在类当中显示的调用本类的构造函数
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
        }


        public Student(string name, int age, char gender):this(name,age,gender,99,99)//重载继承
        //构造函数
        {
            //this.Name = name;//this关键字：代表当前类的对象 在类当中显示的调用本类的构造函数
            //this.Age = age;
            //this.Gender = gender;

        }

        //析构函数 作用：释放资源  因此程序结束的时候析构函数才执行
        ~Student()
        {
            Console.WriteLine("GARBAGExxx");
        }


        static string _name;
        public string Name
        {
            get
            {
                return Student._name;
            }//取值
            set
            {
                Student._name = value;
            }//赋值
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private int _chinese;
        public int Chinese
        {
            get { return _chinese ; }
            set { _chinese = value; }
        }

        private int _math;
        public int Math
        {
            get { return _math ; }
            set { _math = value; }
        }

        public void ShowScore()
        {
            Console.WriteLine("{0}的语文成绩{1}，数学成绩{2}", Name, Chinese, Math);
        }
    }
}
