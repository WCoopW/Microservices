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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Test1",
                Price = 1500,
                CategoryName = "CategoryTest1",
                Description = "Description about test1",
                ImageUrl = "",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Test3",
                Price = 2500,
                CategoryName = "CategoryTest2",
                Description = "Description about test2",
                ImageUrl = "",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Test3",
                Price = 3500,
                CategoryName = "CategoryTest3",
                Description = "Description about test3",
                ImageUrl = "",
            });
        }
    }
}
