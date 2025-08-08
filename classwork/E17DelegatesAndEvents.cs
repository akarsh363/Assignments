//Similar to Function pointers of C++. They are used to pass functions are arguments to other Functions. Example could be predicates that are passed for filtering a collection. The Predicate shall provide a logic on how to filter the collection.
//In C#, callbacks and predicates are implementing using delegate. 
//A Delegate is a signature of a method that can be used to call inside another function. 
//Delegate is more like a function type. 
//Delegates are type-safe and secure, meaning they can only call methods that match their signature.
//There are a list of builtin delegates provided by .net for regular usages:Action,Func,ThreadStart

using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace CSharpBasics
{
    delegate double MathOp(double a, double b);
    internal class Ex17DelegatesAndEvents
    {
        //Func<T> is a generic delegate used to perform operations on different types and parameters.
        static void InvokeFunc(Func<double, double, double> func)
        {
            double v1 = double.Parse(Console.ReadLine());
            double v2 = double.Parse(Console.ReadLine());
            double result = func(v1, v2);
            Console.WriteLine("The result : " + result);
        }
        static void InvokeMethod(MathOp func)
        {
            double v1 = double.Parse(Console.ReadLine());
            double v2 = double.Parse(Console.ReadLine());
            double result = func(v1, v2);
            Console.WriteLine("The result : " + result);
        }
        static void Main(string[] args)
        {
            /////////Old syntax for using the delegate object//////////
            //MathOp obj = new MathOp(add);
            //InvokeMethod(obj);

            /////////New syntax for using the delegate object//////////
            InvokeMethod(add);//Passing the method as a delegate directly
            InvokeMethod(someFun);
        }

        static double add(double a, double b) => a + b;

        static double someFun(double v1, double v2) => v1 * (v2);

    }
}
