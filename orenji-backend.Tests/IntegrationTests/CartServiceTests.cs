using NUnit.Framework;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;
using orenji_backend.Logic;
using orenji_backend.Tests.FakeData;

namespace orenji_backend.Tests.IntegrationTests
{
    public class CartServiceTests
    {
        private readonly CartService _cartService;

        public CartServiceTests()
        {
            _cartService = new CartService(new FakeCartData());
        }

        [Test]
        public void Test_GetAllProductsInCart_True()
        {
            var apiAccount = new ApiAccount("John", "Doe", "a", "a@a.com", "0612345678", SizeTypes.M.ToString(), "User");
            
            Assert.True(_cartService.GetAllProductsInCart(apiAccount).Count == 4);
        }
        
        [Test]
        public void Test_GetAllProductsInCart_False()
        {
            var apiAccount = new ApiAccount("John", "Doe", "a", "a@a.com", "0612345678", SizeTypes.M.ToString(), "User");
            
            Assert.False(_cartService.GetAllProductsInCart(apiAccount).Count == 5);
        }

        [Test]
        public void Test_RemoveProductInCart_True()
        {
            var apiAccount = new ApiAccount("John", "Doe", "a", "a@a.com", "0612345678", SizeTypes.M.ToString(), "User");
            var apiProduct = new ApiProduct("Product1", ProductTypes.Shirt.ToString(), "Company1", 1.99, AudienceTypes.Genderless.ToString(), SizeTypes.M.ToString());
            
            Assert.True(_cartService.RemoveProductInCart(apiProduct, apiAccount));
            
        }
        
        [Test]
        public void Test_RemoveProductInCart_False()
        {
            ApiAccount apiAccount = null;
            var apiProduct = new ApiProduct("Product1", ProductTypes.Shirt.ToString(), "Company1", 1.99, AudienceTypes.Genderless.ToString(), SizeTypes.M.ToString());
            
            Assert.False(_cartService.RemoveProductInCart(apiProduct, apiAccount));
            
        }

        [Test]
        public void Test_AddProductToCart_True()
        {
            var apiAccount = new ApiAccount("John", "Doe", "a", "a@a.com", "0612345678", SizeTypes.M.ToString(), "User");
            var apiProduct = new ApiProduct("Product1", ProductTypes.Shirt.ToString(), "Company1", 1.99, AudienceTypes.Genderless.ToString(), SizeTypes.M.ToString());
            
            Assert.True(_cartService.AddProductToCart(apiProduct, apiAccount));
        }
        
        [Test]
        public void Test_AddProductToCart_False()
        {
            ApiAccount apiAccount = null;
            var apiProduct = new ApiProduct("Product1", ProductTypes.Shirt.ToString(), "Company1", 1.99, AudienceTypes.Genderless.ToString(), SizeTypes.M.ToString());
            
            Assert.False(_cartService.AddProductToCart(apiProduct, apiAccount));
        }
    }
}