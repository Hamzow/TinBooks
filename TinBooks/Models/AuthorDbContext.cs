using Microsoft.EntityFrameworkCore;

namespace TinBooks.Models
{
    public partial class AuthorDbContext : DbContext
    {
        public DbSet<Author> authors { get; set; }
        public object Authors { get; set; }

        public AuthorDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=authors.db");
        }
    }
}