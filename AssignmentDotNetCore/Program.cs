using AssignmentDotNetCore.Data;
using static AssignmentDotNetCore.Data.DBComponents;
using System;

namespace AssignmentDotNetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new BookContextFactory();
            var context = factory.CreateDbContext(args);

            //getAllExample(context);
            //updateExample(context);
            insertExample(context);
            //deleteExample(context);
        }

        private static void getAllExample(BookContext context)
        {
            try
            {
                var records = context.Books.ToList();
                foreach (var record in records)
                {
                    Console.WriteLine(record.Title.ToUpper());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in getAllExample:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
        }

        private static void deleteExample(BookContext context)
        {
            try
            {
                var rec = context.Books.Find(1);
                if (rec == null)
                {
                    Console.WriteLine("No record found to delete.");
                    return;
                }
                context.Books.Remove(rec);
                context.SaveChanges();
                Console.WriteLine("Book deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in deleteExample:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
        }

        private static void updateExample(BookContext context)
        {
            try
            {
                var rec = context.Books.Find(1);
                if (rec != null)
                {
                    rec.Title = "The Tempest";
                    rec.Author = "William Shakespeare";
                    rec.BookPrice = 8;
                    context.SaveChanges();
                    Console.WriteLine("Changes updated successfully.");
                }
                else
                {
                    Console.WriteLine("No record found to update.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in updateExample:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
        }

        private static void insertExample(BookContext context)
        {
            try
            {
                var newBook = new Data.Book
                {
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    BookPrice = 10
                };
                context.Books.Add(newBook);
                context.SaveChanges();
                Console.WriteLine("Book inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in insertExample:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
        }
    }
}
