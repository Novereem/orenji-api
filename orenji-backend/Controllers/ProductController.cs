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
    public class ProductController
    {
        private readonly ProductService _productService;

        public ProductController(OrenjiContext orenjiContext)
        {
            _productService = new ProductService(new ProductData(orenjiContext));
        }
        
        [HttpGet("/products/filter/{query}", Name="filterProducts")]
        public object AllProductsByFilter([FromQuery] Filter filter)
        {
            return _productService.HandleFilter(filter);
        }

        [HttpGet("/products/{productId}")]
        public object GetIndividualProduct(string productId)
        {
            return _productService.GetIndividualProduct(productId);
        }
    }
}