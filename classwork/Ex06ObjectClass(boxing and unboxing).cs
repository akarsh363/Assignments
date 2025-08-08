using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex06ObjectClass_boxing_and_unboxing_
    {
        static void Main(string[] args)
        {
            object obj = 10;
            Console.WriteLine("The data type is " + obj.GetType() .Name);
            obj = "Sample Text";
            Console.WriteLine("The data type is " + obj.GetType() .Name);
            obj = 1234.45562f;
            Console.WriteLine("The data type is " + obj.GetType().Name);

            float f = (float)obj;
            f++;
            Console.WriteLine("The unboxed value is " + f);
        }
    }
}
