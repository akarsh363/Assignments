using System;
using System.Threading;

//Multi Threading is a technique that allows the execution of multiple threads concurrently.
//A Thread is a path of execution within a process. A process can have multiple threads, each executing independently. A Process will have at least one thread, which is the main thread.
//However, for concurrent execution, we need to create additional threads. 
//Threads in .NET are objects of the System.Threading.Thread class. It takes a delegate as a parameter to the constructor, which is the functionality that will be executed in the new thread.
//ThreadStart is the name of the delegate that is used to create a thread. It does not take any parameters and does not return any value.
//However, for passing parameters to the thread, we can use ParameterizedThreadStart delegate. The parameter will always be object type, so we need to cast it to the required type inside the thread function.
//With multiple Threads, U must handle the synchronization of data between threads.
namespace CSharpBasics
{
    internal class Ex25MultiThreading
    {
        static void SomeComplexOperation()
        {
            Console.WriteLine("Into Complex operation");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Complex function is running");
                Thread.Sleep(1000); //Simulating a complex operation by sleeping for 1 second
            }
            Console.WriteLine("Exiting Complex Operation");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Into Main Function");
            //SomeComplexOperation();
            Thread t1 = new Thread(SomeComplexOperation); //Assigning the method to the ThreadStart delegate
            t1.Start(); //Starting the thread
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main function is running");
                Thread.Sleep(1000); //Simulating a complex operation by sleeping for 1 second
            }
            Console.WriteLine("The Main has finished the operation and we are closing it");
        }
    }
}

