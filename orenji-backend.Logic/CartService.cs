using System;
using System.Collections.Generic;
using System.Drawing;
using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Logic
{
    public class CartService
    {
        private readonly ICartData _cartData;

        //You assume that every field has been filled in with the login an register form as that can be better handled by the fronted for a quicker and easier response
        public CartService(ICartData cartData)
        {
            _cartData = cartData;
        }
        
        public List<Product> GetAllProductsInCart(ApiAccount apiAccount)
        {
            var allProductsInCart = _cartData.GetAllProductsInCart(apiAccount);
            
            var allProducts = new List<Product>();
            foreach (var productInCart in allProductsInCart)
            {
                allProducts.Add(_cartData.GetProductFromCart(productInCart));
            }
            
            return allProducts;
        }

        public bool RemoveProductInCart(ApiProduct apiProduct, ApiAccount apiAccount)
        {
            var productInCart = _cartData.GetProductInCart(apiProduct, apiAccount);
            return _cartData.RemoveProductInCart(productInCart);
        }

        public bool AddProductToCart(ApiProduct apiProduct, ApiAccount apiAccount)
        {
            ProductInCart productInCart = new ProductInCart(apiAccount.Id, apiProduct.Id);
            
            return _cartData.AddProductToCart(productInCart);
        }
    }
}