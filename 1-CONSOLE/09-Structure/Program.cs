using System;

namespace _09_Structure
{
    public struct Person
    {
        public string _name;//不叫变量叫字段 虽然目的都是存储数据 但字段可以存储(类型不同的)多值、变量只能一个 【_需要区别命名！】                            
        public int _age;
        public Gender _gender;//char类型变枚举类型
    }


    public enum Gender//枚举类型前是两个黄色小方块
    {
        男,
        女
    }


    public struct Mycolor
    {
        public int _red;
        public int _yellow;
        public int _blue;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson;//声明结构变量 一个变量表示一个人 减少变量数
            zsPerson._name = "张三";
            zsPerson._age = 18;
            zsPerson._gender = Gender.男;

            Person lsPerson;
            lsPerson._name = "李四"; 
            lsPerson._age = 28;

            Console.WriteLine("我叫{0},今年{1}岁，性别{2}",zsPerson._name, zsPerson._age, zsPerson._gender);
            Console.ReadKey();



            Mycolor redcolor;
            redcolor._red = 255;
            redcolor._yellow = 0;
            redcolor._blue = 0;

        }
    }
}
