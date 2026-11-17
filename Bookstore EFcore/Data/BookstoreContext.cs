
using Microsoft.EntityFrameworkCore;
using Bookstore_EFcore.Models;

namespace Bookstore_EFcore.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext()
        {
        }
        public BookstoreContext(DbContextOptions<BookstoreContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=BookstoreDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Auther> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
