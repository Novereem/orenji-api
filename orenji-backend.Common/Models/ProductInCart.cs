using System;
using System.ComponentModel.DataAnnotations;

namespace orenji_backend.Common.Models
{
    public class ProductInCart
    {
        [Key]
        public Guid Id { get; set; }

        public Guid fAccount { get; set; }

        public Guid fProduct { get; set; }

        public ProductInCart()
        {
            
        }
        
        public ProductInCart(Guid account, Guid product)
        {
            Id = Guid.NewGuid();
            fAccount = account;
            fProduct = product;
        }
    }
}