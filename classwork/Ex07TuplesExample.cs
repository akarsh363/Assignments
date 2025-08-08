using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex07TuplesExample
    {
        static void Main(string[] args)
        {
            var myExample = (45, "MyName");
            Console.WriteLine($"FirstItem : {myExample.Item1}, Second Item : {myExample.Item2}");
            Console.WriteLine("The data type is " + myExample.GetType() .Name);

            var person = (Name: "John", Age: 30, City: "New York");
            Console.WriteLine($"Name: {person.Name} from {person.City} and is aged {person.Age}");

            var (longit, latid) = GetCoordinates();

            Console.WriteLine($"The Coordinates are ({longit}, {latid})");
         
        }

        static (double,double) GetCoordinates()
        {
            return (23.34, 43.56);
        }
    }
}
