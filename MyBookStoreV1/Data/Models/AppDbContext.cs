using Microsoft.EntityFrameworkCore;

namespace MyBookStoreV1.Data.Models
{
    public class AppDbContext : DbContext
    {
        private readonly DbContextOptions<AppDbContext> options;


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.options = options;
        }

        public DbSet<Book> Books { get; set; }

    }
}
