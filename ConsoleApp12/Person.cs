using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Person
    {
        private string name;
        private string secondName;
        private string gender;
        private int age;

        public Person()
        {
            this.name = "Name";
            this.secondName = "Second Name";
            this.gender = "Gender";
            this.age = 0;
        }

        public Person(string name, string secondName, string gender, int age)
        {
            this.name = name;
            this.secondName = secondName;
            this.gender = gender;
            this.age = age;
        }

        public void print(Person data)
        {
            Console.WriteLine("Имя: " + name + "\nФамилия: " + secondName + "\nПол: " + gender + "\nВозраст: " + age);
        }
    }
}
