using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AssignmentDotNetCore.Data.DBComponents;

namespace AssignmentDotNetCore.Data
{
    public  class DBComponents
    {
        [Table("Books")]
        public class Book
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [MaxLength(100)]
            public string Title { get; set; }

            [Required]
            [MaxLength(50)]
            public string Author { get; set; }

            [Required]
            public int BookPrice { get; set; }
        }
    }
    public class BookContext : DbContext
    {
        // Scaffold-DBContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LinqDb;Integrated Security=True;Encrypt=False;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data -Tables "Books" 

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
        
        public DbSet<Book> Books { get; set; }
    }
    public class BookContextFactory : IDesignTimeDbContextFactory<BookContext>
    {
        public BookContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<BookContext>();
            var connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new BookContext(optionsBuilder.Options);
        }
    }

}
