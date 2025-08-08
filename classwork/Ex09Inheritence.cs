namespace CSharpBasics
{
    class BaseClass
    {
        public virtual void display()
        {
            Console.WriteLine("Base Class Function");
        }
    }

    class DerivedClass : BaseClass
    {
        public void show()
        {
            Console.WriteLine("Derived Class Method");
        }
    }


    internal class Ex09Inheritence
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.display();
            derivedClass.show();
        }
    }
}