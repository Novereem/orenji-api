using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;

namespace orenji_backend.Data
{
    public class OrenjiContext : DbContext, IOrenjiContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<ProductInCart> ProductInCart { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //Pants
            Product[] pants =
            {
                new Product("Cool Pants", ProductTypes.Pants.ToString(), "The Cool Company", 4.99),
                new Product("Quirky Pants", ProductTypes.Pants.ToString(), "The Quirky Company ", 9.99),
                new Product("Lax Pants", ProductTypes.Pants.ToString(), "The Lax Company ", 1.99)
            };
            modelBuilder.Entity<Product>().HasData(pants);
            
            //Shirts
            Product[] shirts =
            {
                new Product("Modest Shirt", ProductTypes.Shirt.ToString(), "The Modest Company", 12.99),
                new Product("Calm Shirt", ProductTypes.Shirt.ToString(), "The Calm Company", 19.99),
                new Product("Timid Shirt", ProductTypes.Shirt.ToString(), "The Modest Company", 24.99),
                new Product("Adamant Shirt", ProductTypes.Shirt.ToString(), "The Adamant Company", 64.99),
                new Product("Lonely Shirt", ProductTypes.Shirt.ToString(), "The Lonely Company", 14.99),
                new Product("Jolly Shirt", ProductTypes.Shirt.ToString(), "The Jolly Company", 47.99),
                new Product("Brave Shirt", ProductTypes.Shirt.ToString(), "The Brave Company", 34.99)
            };
            modelBuilder.Entity<Product>().HasData(shirts);
            
            //Shoes
            Product[] shoes =
            {
                new Product("Adamant Shirt", ProductTypes.Shoe.ToString(), "The Adamant Company", 12.99),
                new Product("Docile Shirt", ProductTypes.Shoe.ToString(), "The Docile Company", 19.99),
                new Product("Lonely Shirt", ProductTypes.Shoe.ToString(), "The Lonely Company", 24.99),
                new Product("Timid Shirt", ProductTypes.Shoe.ToString(), "The Timid Company", 64.99),
                new Product("Bold Shirt", ProductTypes.Shoe.ToString(), "The Bold Company", 14.99)
            };
            modelBuilder.Entity<Product>().HasData(shoes);

            Account[] accounts =
            {
                new Account("John", "Doe", "a", "a@a.com", "11234567890", SizeTypes.M.ToString()),
                new Account("Joe", "Biden", "b", "b@b.com", "21234567890", SizeTypes.L.ToString()),
                new Account("James", "Howard", "c", "c@c.com", "31234567890", SizeTypes.XL.ToString())
            };
            
            modelBuilder.Entity<Account>().HasData(accounts);
            
            modelBuilder.Entity<ProductInCart>().HasData(
                new ProductInCart(accounts[0].Id, shoes[0].Id),
                new ProductInCart(accounts[0].Id, shoes[1].Id),
                new ProductInCart(accounts[0].Id, shoes[2].Id),
                new ProductInCart(accounts[0].Id, shoes[3].Id),
                new ProductInCart(accounts[0].Id, shoes[4].Id)
            );
        }
        
        //Options
        public OrenjiContext(DbContextOptions<OrenjiContext> options)
            : base(options)
        {
            
        }
    }
}