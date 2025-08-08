﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;//This is the namespace for Generics.

//Generics is a feature of .NET that can allow to create classes, methods and interfaces that can work on any kind of data type. They are similar to templates in C++.
//They are said to be type-safe, meaning that they can enforce type constraints at compile time, reducing runtime errors. U dont have to unbox the data when U use generics, as they are already type-safe.
namespace CSharpBasics
{
    internal class Ex19GenericsDemo
    {
        public static string Password { get; private set; }

        static void Main(string[] args)
        {
            //listExample();
            HashSetExample();
        }

        //HashSet is a collection of unique items. It is similar to a List. No Duplicates are allowed.
        private static void HashSetExample()
        {
            //HashSetSimpleMethod();
            //HashSetOnEmployeeExample();
            DictionaryExample();
        }

        private static void DictionaryExample()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("John", "apple123");
            users.Add("Bob", "mango123");
            users.Add("Joe", "test123");
            users.Add("Micheal", "code123");
            users.Add("Andrews", "ique123");
            users["Jenny"] = "apple123";

            Console.WriteLine("Enter the Username to login: ");
            var userName = Console.ReadLine();

            Console.WriteLine("Enter the password: ");
            var password = Console.ReadLine();
            if (users.ContainsKey(userName) && users[userName] == Password)
            {
                Console.WriteLine("UR Login is successfull");
            }
            else
            {
                Console.WriteLine("UR Login failed. Please check the username and password");
            }
        }

        private static void HashSetOnEmployeeExample()
        {
            //In HashSet, the items are compared using the GetHashCode() and Equals() methods. If two items have the same hash code, then they are compared with the Equals method and then are considered equal/unequal.
            HashSet<Employee> employees = new HashSet<Employee>();
            employees.Add(new Employee { EmpID = 1, EmpName = "John", EmpAddress = "New York", EmpSalary = 50000, Designation = "Manager" });
            employees.Add(new Employee { EmpID = 2, EmpName = "Jane", EmpAddress = "Los Angeles", EmpSalary = 60000, Designation = "Developer" });
            employees.Add(new Employee { EmpID = 3, EmpName = "Doe", EmpAddress = "Chicago", EmpSalary = 55000, Designation = "Tester" });
            employees.Add(new Employee { EmpID = 4, EmpName = "Alice", EmpAddress = "Houston", EmpSalary = 70000, Designation = "Designer" });
            employees.Add(new Employee { EmpID = 5, EmpName = "Bob", EmpAddress = "Phoenix", EmpSalary = 65000, Designation = "Analyst" });
            employees.Add(new Employee { EmpID = 1, EmpName = "John", EmpAddress = "New York", EmpSalary = 50000, Designation = "Manager" });
            employees.Add(new Employee { EmpID = 1, EmpName = "John", EmpAddress = "New York", EmpSalary = 50000, Designation = "Manager" });

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.EmpName} earns a salary of {emp.EmpSalary:C}");
            }
        }

        private static void HashSetSimpleMethod()
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("John");
            names.Add("Jane");
            names.Add("Doe");
            if (!names.Add("John"))
                Console.WriteLine("John is already the member of the  Team");
            Console.WriteLine("The total members of the team: " + names.Count);
        }

        private static void listExample()
        {
            List<string> names = new List<string>();
            names.Add("John");//Add only strings to the list.
            names.Add("Jane");
            names.Add("Doe");
            names.Add("Smith");
            names.Add("Alice");
            names.Add("Bob");
            names.Insert(2, "Charlie");//Insert at index 2. This will shift the other items to the right.

            //Iterating through the list using foreach loop. foreach is a easy way to iterate through a collection in C#. It is forward-only and readonly. U can move by 1 number at a time.
            foreach (string name in names)
            {
                Console.WriteLine(name.ToUpper());//No unboxing is required as the list is of type string.
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
                //for(int i =0; i < names.Count; i++)
                //{
                //    if(names[i] == nameToFind)
                //    {
                //        Console.WriteLine($"UR Entered Name is found at index {i}");
                //        break; //Exit the loop once the name is found.
                //    }
                //}
                var index = names.IndexOf(nameToFind); //This will return the index of the name if found, otherwise -1.
                Console.WriteLine($"UR Entered Name is found at index {index}");
            }
        }
    }
}


