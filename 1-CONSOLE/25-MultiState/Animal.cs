using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _25_MultiState
{
    public abstract class Animal
    {
        private string _name;//字段
        public string Name//属性
        {
            get { return _name; }
            set { _name = value; }
}
        public Animal(string name)//构造函数
        {
            this.Name = name;
        }
        public abstract void Yell();//方法 抽象的意义：让子类重写
        internal abstract void Fly();
        internal abstract void Swim();
    }
}
