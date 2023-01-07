using System;
using Microsoft.EntityFrameworkCore;
using orenji_backend.Common.Models;

namespace orenji_backend.Common.Interfaces
{
    public interface IOrenjiContext : IDbContext, IDisposable
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Account> Account { get; set; }
        
        public DbSet<ProductInCart> ProductInCart { get; set; }
    }
}