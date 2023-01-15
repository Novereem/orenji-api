using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
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
    public class CartController : Controller
    {
        private readonly CartService _cartService;
        private readonly AuthenticationService _authenticationService;
        
        public CartController(OrenjiContext orenjiContext)
        {
            _cartService = new CartService(new CartData(orenjiContext));
            _authenticationService = new AuthenticationService();
        }
        
        [HttpPost("/cart/")]
        public object AllProductsInCart()
        {
            return _cartService.GetAllProductsInCart(TokenToApiAccount());
        }
        
        [HttpDelete("/cart/{productId}")]
        public bool RemoveProductInCart(string productId)
        {
            var apiProduct = new ApiProduct
            {
                Id = Guid.Parse(productId)
            };
            return _cartService.RemoveProductInCart(apiProduct, TokenToApiAccount());
        }
        
        [HttpPost("/cart/{productId}")]
        public bool AddProductToCart(string productId)
        {
            var apiProduct = new ApiProduct
            {
                Id = Guid.Parse(productId)
            };
            return _cartService.AddProductToCart(apiProduct, TokenToApiAccount());
        }
        
        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        private ApiAccount TokenToApiAccount()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            return _authenticationService.TokenToApiAccount(identity);
        }
    }
}