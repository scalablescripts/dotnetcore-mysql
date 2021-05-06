using dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 50; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = i,
                        Title = new Bogus.DataSets.Lorem().Word(),
                        Description = new Bogus.DataSets.Lorem().Paragraph(),
                        Image = new Bogus.DataSets.Images().LoremPixelUrl(),
                        Price = new Bogus.Randomizer().Number(10, 100)
                    }
                );
            }
        }
    }
}