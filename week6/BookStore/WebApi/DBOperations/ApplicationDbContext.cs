using Microsoft.EntityFrameworkCore;

namespace WebApi.DBOperations
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
      
    }
}