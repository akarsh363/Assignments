using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Person
    {
        public string name;
        public int age;

        public Person(string personName, int personAge)
        {
            name = personName;
            age = personAge;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name:{name}, Age : {age}");
        }
    }
    internal class E15Constructor
    {

        static void Main(string[] args)
        {
            Person p1 = new Person("Akarsh", 23);
            p1.ShowDetails();
        }
    }
}

