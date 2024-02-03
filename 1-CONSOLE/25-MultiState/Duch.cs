using System;
using System.Collections.Generic;
using System.Text;

namespace _25_MultiState
{
    public class Duch : Animal,ISwimable
    {
        public Duch(string name) : base(name)
        {

        }

        public void Swim()
              {
            Console.WriteLine("{0}swim", Name);
        }

        void ISwimable.Swim()//显示实现接口解决方法重名
        {
            Console.WriteLine(" CAN SWIM(接口)");
        }

        public override void Yell()//子类成员和父类一样  会隐藏父类（调不到）
        {
            Console.WriteLine("{0}gaga", Name);// 使用基类 Animal 中的属性 Name
        }
    }
    public interface ISwimable
    {
        void Swim();
    }
}
