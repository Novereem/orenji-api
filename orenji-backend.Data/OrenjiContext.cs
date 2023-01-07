using Microsoft.EntityFrameworkCore;
using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;

namespace orenji_backend.Data
{
    public class OrenjiContext : DbContext, IOrenjiContext
    {
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product("Pants name", ProductTypes.Pants.ToString(),"Company name", "5 dollar"),
                new Product("Pants name", ProductTypes.Pants.ToString(),"Company name", "10 dollar")
            );
        }
        
        public OrenjiContext(DbContextOptions<OrenjiContext> options)
            : base(options)
        {
            
        }
    }
}