using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{   
    interface IExample
    {
        void ShowExample();
    }
    interface ISimple
    {
        void ShowSimple();
    }

    class simpleExample : IExample, ISimple //Multiple interface
    {
        public void ShowExample() {
            Console.WriteLine("This is an example of implementing multiple interfaces");
             }

        public void ShowSimple()
        {
            Console.WriteLine("This is an explicit implementation of ShowExample Method for IExample2");
        }

        void IExample.ShowExample()
        {
            Console.WriteLine("This is an explicit implentation of ShoeExample Method for IExample");
        }
    }
    internal class Ex13AdvanceInterfacecs
    {

    }
}
