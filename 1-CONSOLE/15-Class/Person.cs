using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class
{
    [Serializable]//1、标注序列化
    public class Person
    {
        //Fields字段 必须是私有的——默认就是private
        private string _name;
        private int _age;
        private char _gender;//private：只能在当前类的内部访问 


        //Methods方法
        //public Person();
        public void CHLSS()
        {
            Console.WriteLine("{0}这个{1}岁的{2}人今年可以吃喝拉撒睡",this.Name, this.Age,this.Gender);//this表现当前这个类的对象
        }


        //Properties属性 get和set是属性本身有的两个方法
        public string Name
        {
            get {
                if (_name!="susam")
                {
                    return _name = "susan";
                }
                
                return _name; }//属性本质上是两个方法 (对属性                                          字段
                                //取值
            set {
                _name = value; }//赋值（属性是不存值的过渡 最终再给字段     ——属性是对字段的保护）         VALUE
        }
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
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
