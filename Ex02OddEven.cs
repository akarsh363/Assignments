using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Ex02OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers you want to give as input");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[count];

            for(int i=0; i<count; i++)
            {
                Console.WriteLine($"Enter the Number : {i+1}");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            showOddEven(numbers);
        }
        static void showOddEven(int[] numbers)
        {
            Console.WriteLine("Even Number");
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine("Odd Number");
            foreach (int i in numbers)
            {
                if(i % 2 == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
