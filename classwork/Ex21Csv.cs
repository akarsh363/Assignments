using CSarpBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex21Csv
    {
        private static string filepath;

        private static void creatingCsvFile()
        {
            var customer = new Customer
            {
                CustomerId = 123,
                CustomerName = "Joe",
                BillAmount = 5000
            };

            var content = $"{customer.CustomerId},{customer.CustomerName},{customer.BillAmount}\n";
            File.WriteAllText(filepath, content); // Writes th the file, if the file does not exist, it shall create the file and write to it, if the file exists,it shall overwrite the contents.
        }
        static void Main(string[] args)
        {
            creatingCsvFile();
        }
    }
}
