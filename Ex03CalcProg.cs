using System;

namespace Assignments
{
    internal class Ex03CalcProg
    {   
        static int GetIntValue(string str)
        {
            Console.WriteLine(str);
            return int.Parse(Console.ReadLine());
        }

        static string GetStringValue(string str)
        { 
               Console.WriteLine(str);
               str = Console.ReadLine();
               return str;
             
        }

        static int GetResult(int val1,int val2,string operand)
        {   
                switch (operand)
                {
                    case "+": return val1 + val2;

                    case "-": return val1 - val2;

                    case "*": return val1 * val2;

                    case "/": return val1 / val2;

                    default:
                        Console.WriteLine("Enter the valid choice");
                        return 0;
            }
        }
        static void Main(string[] args)
        {
            bool processing = false;
            do
            {
                int val1 = GetIntValue("Enter the First Number");

                int val2 = GetIntValue("Enter the Second Number");

                string operand = GetStringValue("Enter the Operand");

                int result = GetResult(val1, val2, operand);

                Console.WriteLine("The Result is : {0}", result);

                string choice = GetStringValue("Press Y to continue and any other key to quit");

                processing = choice.ToUpper() == "Y" ? true : false;
            }
            while (processing);
        }
    }
    
}
