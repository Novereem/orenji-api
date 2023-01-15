using System;
using System.Collections.Generic;
using System.Linq;
using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;

namespace orenji_backend.Tests.FakeData
{
    public class FakeProductData : IProductData
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product("Cool Pants", ProductTypes.Pants.ToString(), "The Cool Company", 4.99, AudienceTypes.Male.ToString(),SizeTypes.M.ToString()),
            new Product("Quirky Pants", ProductTypes.Pants.ToString(), "The Quirky Company ", 9.99, AudienceTypes.Male.ToString(),SizeTypes.L.ToString()),
            new Product("Lax Pants", ProductTypes.Pants.ToString(), "The Lax Company ", 1.99, AudienceTypes.Female.ToString(),SizeTypes.M.ToString()),
            new Product("Modest Shirt", ProductTypes.Shirt.ToString(), "The Modest Company", 12.99, AudienceTypes.Male.ToString(),SizeTypes.M.ToString()),
            new Product("Calm Shirt", ProductTypes.Shirt.ToString(), "The Calm Company", 19.99, AudienceTypes.Male.ToString(),SizeTypes.L.ToString()),
            new Product("Timid Shirt", ProductTypes.Shirt.ToString(), "The Modest Company", 24.99, AudienceTypes.Female.ToString(),SizeTypes.M.ToString()),
            new Product("Adamant Shirt", ProductTypes.Shirt.ToString(), "The Adamant Company", 64.99, AudienceTypes.Female.ToString(),SizeTypes.S.ToString()),
            new Product("Lonely Shirt", ProductTypes.Shirt.ToString(), "The Lonely Company", 14.99, AudienceTypes.Genderless.ToString(),SizeTypes.XS.ToString()),
            new Product("Jolly Shirt", ProductTypes.Shirt.ToString(), "The Jolly Company", 47.99, AudienceTypes.Genderless.ToString(),SizeTypes.M.ToString()),
            new Product("Brave Shirt", ProductTypes.Shirt.ToString(), "The Brave Company", 34.99, AudienceTypes.Genderless.ToString(),SizeTypes.M.ToString()),
            new Product("Adamant Shirt", ProductTypes.Shoe.ToString(), "The Adamant Company", 12.99, AudienceTypes.Male.ToString(),SizeTypes.M.ToString()),
            new Product("Docile Shirt", ProductTypes.Shoe.ToString(), "The Docile Company", 19.99, AudienceTypes.Female.ToString(),SizeTypes.M.ToString()),
            new Product("Lonely Shirt", ProductTypes.Shoe.ToString(), "The Lonely Company", 24.99, AudienceTypes.Female.ToString(),SizeTypes.S.ToString()),
            new Product("Timid Shirt", ProductTypes.Shoe.ToString(), "The Timid Company", 64.99, AudienceTypes.Female.ToString(),SizeTypes.L.ToString()),
            new Product("Bold Shirt", ProductTypes.Shoe.ToString(), "The Bold Company", 14.99, AudienceTypes.Male.ToString(),SizeTypes.L.ToString())
        };
        public List<Product> GetAllProductsByAudienceType(string audienceType)
        {
            return _products.Where(x => x.AudienceType == audienceType).ToList();
        }

        public List<Product> GetAllProductsByAudienceAndClothingType(string audienceType, string clothingType)
        {
            return _products.Where(x => x.AudienceType == audienceType && x.Type == clothingType).ToList();
        }

        public List<Product> GetAllProductsByAudienceAndSize(string audienceType, string size)
        {
            return _products.Where(x => x.AudienceType == audienceType && x.Size == size).ToList();
        }

        public List<Product> GetAllProductsByAudienceClothingTypeAndSize(string audienceType, string clothingType, string size)
        {
            return _products.Where(x => x.AudienceType == audienceType && x.Type == clothingType && x.Size == size).ToList();
        }

        public Product GetIndividualProduct(string productId)
        {
            if (Guid.TryParse(productId, out var guidValue))
            {
                return new Product("Bold Shirt", ProductTypes.Shoe.ToString(), "The Bold Company", 14.99, AudienceTypes.Male.ToString(), SizeTypes.L.ToString());
            }

            return null;
        }
    }
}