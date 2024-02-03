using System;

namespace _18_Inherit
{
    /// <summary>
    /// The base class representing a person.
    /// </summary>
    public class Person
    {
        public Person()
        {
        }
        /// <summary>
        /// Destructor. Called when the object is being finalized by the garbage collector.
        /// </summary>
        ~Person()
        {
            Console.WriteLine("GARBAGExxx");
        }


        public Person(string name, int age, char gender)
        {
            // Set the properties using the provided values.
            //在C#中，对于属性（Properties）而言，常用 this 关键字来引用类的成员，而对于字段（Fields）则常用下划线（_）作为前缀。
            //在 Person 类中，使用 this.Name = name; 的形式，是因为 Name 在该类中是一个属性，而不是字段。属性通常用于封装私有字段，并提供对字段的访问。这样的写法有助于将属性和字段区分开
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        private static string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                // Validate age to be between 0 and 100.
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

        public void SayHi()
        {
            Console.WriteLine("HI");
        }
    }
}
