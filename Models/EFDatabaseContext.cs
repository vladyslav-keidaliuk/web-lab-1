using Microsoft.EntityFrameworkCore;

namespace WEB_Lab_1.Models
{


    public class EFDatabaseContext : DbContext
    {
        public EFDatabaseContext(DbContextOptions<EFDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}