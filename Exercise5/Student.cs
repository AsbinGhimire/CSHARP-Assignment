using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Student
    {
        private string Name;
        private int Age;
        private string Major;
        public Student(string name, int age, string major)
        {
            Name = name;
            Age = age;
            Major = major;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, It's me {Name}, I'm {Age} years old and majoring in {Major}");
        }

   
    }
    
}
