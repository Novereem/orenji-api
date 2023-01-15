using System;
using System.Drawing;
using NUnit.Framework;
using orenji_backend.Common.Models;
using orenji_backend.Logic;
using orenji_backend.Tests.FakeData;

namespace orenji_backend.Tests.IntegrationTests
{
    public class ProductServiceTests
    {
        private readonly ProductService _productService;

        public ProductServiceTests()
        {
            _productService = new ProductService(new FakeProductData());
        }

        [Test]
        public void Test_GetAllProductsByAudienceType_Male_True()
        {
            Assert.True(_productService.GetAllProductsByAudienceType(AudienceTypes.Male.ToString()).Count == 6);
        }
        [Test]
        public void Test_GetAllProductsByAudienceType_Female_True()
        {
            Assert.True(_productService.GetAllProductsByAudienceType(AudienceTypes.Female.ToString()).Count == 6);
        }

        [Test]
        public void Test_GetAllProductsByAudienceAndClothingType_MaleShirt_True()
        {
            Assert.True(_productService.GetAllProductsByAudienceAndClothingType(AudienceTypes.Male.ToString(), ProductTypes.Shirt.ToString()).Count == 2);
        }
        [Test]
        public void Test_GetAllProductsByAudienceAndClothingType_FemalePants_True()
        {
            Assert.True(_productService.GetAllProductsByAudienceAndClothingType(AudienceTypes.Female.ToString(), ProductTypes.Pants.ToString()).Count == 1);
        }

        [Test]
        public void Test_AllProductsByAudienceAndSize_MaleM_True()
        {
            Assert.True(_productService.GetAllProductsByAudienceAndSize(AudienceTypes.Male.ToString(), SizeTypes.M.ToString()).Count == 3);
        }
        [Test]
        public void Test_AllProductsByAudienceAndSize_FemaleL_True()
        {
            Assert.True(_productService.GetAllProductsByAudienceAndSize(AudienceTypes.Female.ToString(), SizeTypes.L.ToString()).Count == 1);
        }

        [Test]
        public void Test_GetAllProductsByAudienceClothingTypeAndSize_MaleShirtM_True()
        {
            Assert.True(_productService.GetAllProductsByAudienceClothingTypeAndSize(AudienceTypes.Male.ToString(), ProductTypes.Shirt.ToString(), SizeTypes.M.ToString()).Count == 1);
        }
        [Test]
        public void Test_GetAllProductsByAudienceClothingTypeAndSize_FemaleShoeL_True()
        {
            Assert.True(_productService.GetAllProductsByAudienceClothingTypeAndSize(AudienceTypes.Female.ToString(), ProductTypes.Shoe.ToString(), SizeTypes.L.ToString()).Count == 1);
        }

        [Test]
        public void Test_GetIndividualProduct_True()
        {
            var guid = Guid.NewGuid();
            Assert.True(_productService.GetIndividualProduct(guid.ToString()) != null);
        }
    }
}