using System;
using System.Collections.Generic;
using System.Text;

namespace _25_MultiState
{
    public class Person
    {
        private string _name;//私有字段（field）
        public string Name//公共属性
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(string name)//构造函数
        {
            this.Name = name;//将构造函数的参数值赋给了属性 Name进行初始化   (这个属性对应的字段是 _name)以便触发属性的 set 访问器中的逻辑
        } 

        public virtual void SayHi()//方法
        {
            Console.WriteLine("HI I AM {0}",_name);
        }
    }
}
