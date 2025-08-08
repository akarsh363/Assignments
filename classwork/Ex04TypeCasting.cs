using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex04TypeCasting
    {
        static void Main(string[] args)
        {
            void TypecastingExample()
            {
                int ival = 123;
                long lval = ival;
                double dval = 123.45;
                lval = (long)dval;
                Console.WriteLine(lval);
                lval = Convert.ToInt32(dval);
                Console.WriteLine(lval);

            }
        }
        
    }
}
