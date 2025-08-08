using System;

namespace Assignments
{
    internal class Ex02OddEven
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter how many numbers you want to give as input");
            int count = Convert.ToInt32(Console.ReadLine());
                        // int.parse(console.RadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter the Number : {i + 1}");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                             // int.parse(console.Readline());
            }

            showOddEven(numbers);
        }
        static void showOddEven(int[] numbers)
        {
            Console.WriteLine("Even Numbers");
            foreach (int i in numbers)
            {
                if (i%2 == 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine("Odd Numbers");
            foreach (int i in numbers)
            {
                  if (i%2 != 0)
                    // if(i%2 == 1)
               
                    Console.WriteLine(i);
            }
        }
    }
}
