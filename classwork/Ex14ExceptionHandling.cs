using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex14ExceptionHandling
    {
        static void Main(string[] args)
        {
        RETRY:
            try
            {
                Console.WriteLine("Enter your Age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("The age is " + age);
            }
            catch (OverflowException ex1)
            {
                Console.WriteLine($"The System generated the message : {ex1.Message}");
                Console.WriteLine($"Input must be within {int.MinValue} and {int.MaxValue}");
                goto RETRY;
            }
            catch (FormatException ex2)
            {
                Console.WriteLine($"The System generated the message : {ex2.Message}");
                Console.WriteLine($"In put should be valid number");
                goto RETRY;
            }
            catch(DivideByZeroException ex3)
            {
                Console.WriteLine($"The System generated the message : {ex3.Message}");
                Console.WriteLine("Divide by zero is not allowed");
            }
            finally
            {   
                // finally always runs
                // u cannot have goto,break,continue or return in finally block
                Console.WriteLine("This is finally block");
            }

            
        }
    }
}
