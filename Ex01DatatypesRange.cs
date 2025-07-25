using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Ex01DatatypesRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integral Types");
            Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"iny : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");
            Console.WriteLine("Floating Types");
            Console.WriteLine($"Float : {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue}");

        }
    }
}
