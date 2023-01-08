using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;
using orenji_backend.Data;
using orenji_backend.Logic;

namespace orenji_backend.Controllers
{
    [EnableCors("AllowCors")]
    [ApiController]
    [Route("[controller]")]
    public class CartController
    {
        private readonly CartService _cartService;
        
        public CartController(OrenjiContext orenjiContext)
        {
            _cartService = new CartService(new CartData(orenjiContext));
        }
        
        [HttpPost("/cart/")]
        public object AllProductsInCart([FromBody]ApiAccount apiAccount)
        {
            return _cartService.GetAllProductsInCart(apiAccount);
        }
        
        [HttpPost("/cart/remove/{productId}")]
        public bool RemoveProductInCart(string productId, [FromBody]ApiAccount apiAccount)
        {
            var apiProduct = new ApiProduct
            {
                Id = Guid.Parse(productId)
            };
            return _cartService.RemoveProductInCart(apiProduct,apiAccount);
        }
        
        [HttpPost("/cart/add/{productId}")]
        public bool AddProductToCart(string productId, [FromBody]ApiAccount apiAccount)
        {
            var apiProduct = new ApiProduct
            {
                Id = Guid.Parse(productId)
            };
            return _cartService.AddProductToCart(apiProduct, apiAccount);
        }
    }
}