using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _25_MultiState
{
    public class Chick:Animal, IFlyable
    {
        public Chick (string name) : base(name)
        {

        }

        public override void Yell()//子类成员和父类一样  会隐藏父类（调不到）
        {
            Console.WriteLine("{0}gugu", Name);// 使用基类 Animal 中的属性 Name
        }

        public void Fly()
        {
            Console.WriteLine("{0}fly", Name);// 使用基类 Animal 中的属性 Name
        }

        void IFlyable.Fly()//显示实现接口解决方法重名
        {
            Console.WriteLine(" CAN FLY(接口)");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }
}
