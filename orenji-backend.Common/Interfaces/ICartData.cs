using System;
using System.Collections.Generic;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Common.Interfaces
{
    public interface ICartData
    {
        public Product GetProductFromCart(ProductInCart productInCart);
        public ProductInCart GetProductInCart(ApiProduct apiProduct, ApiAccount apiAccount);
        public List<ProductInCart> GetAllProductsInCart(ApiAccount apiAccount);
        public bool RemoveProductInCart(ProductInCart productInCart);
        public bool AddProductToCart(ProductInCart productInCart);
    }
}