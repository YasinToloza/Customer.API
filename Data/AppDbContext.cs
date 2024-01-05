using Microsoft.EntityFrameworkCore;
namespace Customer.API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() 
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.Customer> Customers { get; set; }
    }
}