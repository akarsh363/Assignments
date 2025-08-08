using System;

namespace Assignments
{
    internal class Ex01DatatypesRange
    {   
        // Integer Types...
        static void IntegralTypes()
        {
            Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");
        }

        // Floating Types...
        static void FloatingTypes()
        {
            Console.WriteLine($"Float : {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue}");
        }
        static void Main(string[] args)
        {
            IntegralTypes();

            FloatingTypes();
        }
    }
}
