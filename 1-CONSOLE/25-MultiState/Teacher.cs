using System;
using System.Collections.Generic;
using System.Text;

namespace _25_MultiState
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {

        }

        public override void SayHi()//子类成员和父类一样  会隐藏父类（调不到）
        {
            Console.WriteLine("Hi I am teacher! ");
        }

        public void Mentor()//子类成员和父类一样  会隐藏父类（调不到）
        {
            Console.WriteLine("Hi I am teaching! ");
        }
    }
}
