using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//////////    OUT,REF,PARAMS     ////////////
//out parameter value is assigned inside the function and the ref parameter initialized before passing it to the function
namespace CSharpBasics
{
    internal class Ex16ParametersDemo
    {   
        public static int NormalParameter(int x)
        {
            x = x + 10;
            return x;
        }

        public static void ADDFUNC(int val1, int val2, out double r1)
        {
             r1 = val1 + val2;

        }

        static void AddFive(ref int num)
        {
            num = num + 10;
        }

        static void PrintNumbers(params int[] numbers)
        {
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        static void Main(string[] args)
        {
            int x = 10;
            NormalParameter(x);
            Console.WriteLine("X value after returning from the function: " +x);

            ///out parameters///
            double result;
            ADDFUNC(10, 20, out result);
            //retains the result in the out parameter.
            //Even after the method call,the out parameter retains the value assigned in the method.
            Console.WriteLine("the result: " + result);

            int value = 100;
            AddFive(ref value);
            Console.WriteLine(value);

            PrintNumbers(1, 2, 3);
            PrintNumbers(10);
            PrintNumbers();
        }
    }
}
