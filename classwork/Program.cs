namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Address");
            string address = Console.ReadLine();

            Console.WriteLine($"The Inputs are as follows : \n The Name entered is {name} \n The Address is {address}");
        }
    }
}
