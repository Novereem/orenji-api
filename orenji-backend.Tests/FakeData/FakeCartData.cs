using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Tests.FakeData
{
    public class FakeCartData : ICartData
    {
        private readonly List<Product> _products = new List<Product>()
        {
            new Product("Product1", ProductTypes.Shirt.ToString(), "Company1", 1.99, AudienceTypes.Genderless.ToString(), SizeTypes.M.ToString()),
            new Product("Product2", ProductTypes.Shirt.ToString(), "Company2", 2.99, AudienceTypes.Genderless.ToString(), SizeTypes.L.ToString()),
            new Product("Product3", ProductTypes.Shirt.ToString(), "Company3", 3.99, AudienceTypes.Kids.ToString(), SizeTypes.S.ToString()),
            new Product("Product4", ProductTypes.Shirt.ToString(), "Company4", 4.99, AudienceTypes.Female.ToString(), SizeTypes.M.ToString()),
            new Product("Product5", ProductTypes.Shirt.ToString(), "Company5", 5.99, AudienceTypes.Male.ToString(), SizeTypes.L.ToString()),
        };
        
        
        public Product GetProductFromCart(ProductInCart productInCart)
        {
            return _products.First(x => x.Id.ToString() == productInCart.fProduct.ToString());
        }

        public ProductInCart GetProductInCart(ApiProduct apiProduct, ApiAccount apiAccount)
        {
            return new ProductInCart(apiAccount.Id, apiProduct.Id);
        }

        public List<ProductInCart> GetAllProductsInCart(ApiAccount apiAccount)
        {
            var productInCart = new List<ProductInCart>
            {
                new ProductInCart(apiAccount.Id, _products[0].Id),
                new ProductInCart(apiAccount.Id, _products[1].Id),
                new ProductInCart(apiAccount.Id, _products[2].Id),
                new ProductInCart(apiAccount.Id, _products[3].Id),
            };
            return productInCart;
        }

        public bool RemoveProductInCart(ProductInCart productInCart)
        {
            if (productInCart.fProduct != null && productInCart.fAccount != null)
            {
                return true;
            }

            return false;
        }

        public bool AddProductToCart(ProductInCart productInCart)
        {
            if (productInCart.fProduct != null && productInCart.fAccount != null)
            {
                return true;
            }
            
            return false;
        }
    }
}