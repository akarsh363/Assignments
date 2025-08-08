namespace CSharpBasics
{
    internal class Ex02DataTypes1
    {
        static void Main()
        {
            int ival = 123;
            long lval = 234324343;
            float fval = 234.261f;
            double dval = 213616.6464616;
            char strText = 'a';
            DisplayUserDetails();
        }

        static void DisplayUserDetails()
        {
            Console.WriteLine("Enter the Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Age");

            int iAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your mobile no");
            long lmobile = long.Parse(Console.ReadLine());

            Console.WriteLine($"The age is {iAge} \n mobile no is {lmobile} \n ");
        }
            
    }
}
