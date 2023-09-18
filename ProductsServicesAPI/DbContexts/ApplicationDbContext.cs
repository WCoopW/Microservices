using Microsoft.EntityFrameworkCore;
using ProductsServicesAPI.Models;

namespace ProductsServicesAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
    }
}
