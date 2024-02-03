using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Inherit
{
    public class Teacher : Person
    {
        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public void ShowSalary()
        {
            Console.WriteLine("{0}的工资{1}", Name, Salary);
        }

        public void TeacherSayHi()
        {
            Console.WriteLine("HI。u。");
        }

        //public new void SayHi()
        //{
        //    Console.WriteLine("HI。u。");
        //}

        public Teacher(string name, int age, char gender, int salary) : base(name, age, gender)
        {
            this.Salary = salary;
        }
    }
}
