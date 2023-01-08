using System.Collections.Generic;
using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Logic
{
    public class ProductService
    {
        private readonly IProductData _productData;
        public ProductService(IProductData productData)
        {
            _productData = productData;
        }

        public object HandleFilter(Filter filter)
        {
            if (filter.Size == null && filter.Audience != null && filter.Type == null)
            {
                return GetAllProductsByAudienceType(filter.Audience);
            }

            if (filter.Size == null && filter.Audience != null && filter.Type != null)
            {
                return GetAllProductsByAudienceAndClothingType(filter.Audience, filter.Type);
            }
            
            if (filter.Size != null && filter.Audience != null && filter.Type == null)
            {
                return AllProductsByAudienceAndSize(filter.Audience, filter.Size);
            }
            
            if (filter.Size != null && filter.Audience != null && filter.Type != null)
            {
                return AllProductsByAudienceClothingTypeAndSize(filter.Audience, filter.Type, filter.Size);
            }

            return null;
        }
        
        public List<Product> GetAllProductsByAudienceType(string audienceType)
        {
            return _productData.GetAllProductsByAudienceType(audienceType);
        }

        public List<Product> GetAllProductsByAudienceAndClothingType(string audienceType, string clothingType)
        {
            return _productData.GetAllProductsByAudienceAndClothingType(audienceType, clothingType);
        }
        
        public List<Product> AllProductsByAudienceAndSize(string audienceType,string size)
        {
            return _productData.AllProductsByAudienceAndSize(audienceType, size);
        }
        
        public List<Product> AllProductsByAudienceClothingTypeAndSize(string audienceType, string clothingType,string size)
        {
            return _productData.AllProductsByAudienceClothingTypeAndSize(audienceType, clothingType, size);
        }

        public Product GetIndividualProduct(string product)
        {
            return _productData.GetIndividualProduct(product);
        }
    }
}