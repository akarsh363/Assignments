using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex05ArraysExample
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            names[0] = "John";
            names[1] = "Jane";
            names[2] = "Alice";
            names[3] = "Bob";
            names[4] = "Charlie";

            for(int index = 0; index < names.Length; index++)
            {
                Console.WriteLine(names[index]);
            }

            Console.WriteLine("\n");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
       
        }
    }
}
