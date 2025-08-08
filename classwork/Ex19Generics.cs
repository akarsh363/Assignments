using System;
using System.Collections.Generic; //This is the namespace for Generics.

//Generics is a feature of .NET that can allow to create classes, methods and interfaces that can work on any kind of data type. They are similar to templates in C++. They are said to be type-safe, meaning that they can enforce type constraints at compile time, reducing runtime errors. U dont have to unbox the data when U use generics, as they are already type-safe.
namespace CSharpBasics
{
    internal class Ex19Generics
    {
        static void Main(string[] args)
        {
            listExample();
            HashSetExample();
        }

        //HashSet is a collection of unique items.It is similar to a List.No Duplicates are allowed.

        private static void HashSetExample()
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("John");
            names.Add("Jane");
            names.Add("Doe");
            if(!names.Add("John"))
                Console.WriteLine("John is already the member of the Team");
            Console.WriteLine("The total members of the team: " + names.Count);
        }

        private static void listExample()
        {
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");
            names.Add("Micheal");
            names.Add("Henry");
            names.Insert(2, "Smith");

            //Iterating through the list using foreach loop. foreach is a easy way to iterate through a collection in C#. It is forward-only and readonly. U can move by 1 number at a time.

            foreach (string name in names)
            {
                Console.WriteLine(name.ToUpper());

            }
            //Like ArrayList, here also U can insert, remove, and search for items in the list from any where.
            Console.WriteLine("Enter a name to find: ");
            string nameToFind = Console.ReadLine();
            if (!names.Contains(nameToFind))
            {
                Console.WriteLine("UR Entered Name does not exist");
            }
            else
            {
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i] == nameToFind)
                    {
                        Console.WriteLine($"UR Entered Name is found at index {i}");
                        break; //Exit the loop once the name is found.
                    }
                }
            } //var index = names.IndexOf(nameToFind);

        }
    }
}

