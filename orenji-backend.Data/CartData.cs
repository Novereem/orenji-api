using System;
using System.Collections.Generic;
using System.Linq;
using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Data
{
    public class CartData : ICartData
    {
        private readonly IOrenjiContext _orenjiContext;
        
        public CartData(IOrenjiContext orenjiContext)
        {
            _orenjiContext = orenjiContext;
        }
        
        public Product GetProductFromCart(ProductInCart productInCart)
        {
            return _orenjiContext.Product.First(x => x.Id.ToString() == productInCart.fProduct.ToString());
        }

        public ProductInCart GetProductInCart(ApiProduct apiProduct, ApiAccount apiAccount)
        {
            return _orenjiContext.ProductInCart.First(x => x.fProduct.ToString() == apiProduct.Id.ToString() && x.fAccount.ToString() == apiAccount.Id.ToString());
        }

        public List<ProductInCart> GetAllProductsInCart(ApiAccount apiAccount)
        {
            return _orenjiContext.ProductInCart.Where(x => x.fAccount.ToString() == apiAccount.Id.ToString()).ToList();
        }

        public bool RemoveProductInCart(ProductInCart productInCart)
        {
            _orenjiContext.ProductInCart.Remove(productInCart);
            int changes = _orenjiContext.SaveChanges();
            if (changes > 0)
            {
                return true;
            }

            return false;
        }

        public bool AddProductToCart(ProductInCart productInCart)
        {
            _orenjiContext.ProductInCart.Add(productInCart);
            int changes = _orenjiContext.SaveChanges();
            if (changes > 0)
            {
                return true;
            }

            return false;
        }
    }
}