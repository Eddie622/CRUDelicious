using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) {}

        // Add tables here
        public DbSet<Dish> Dishes { get;set; }
    }
}