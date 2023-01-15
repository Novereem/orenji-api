using System.Collections.Generic;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Common.Interfaces
{
    public interface IProductData
    {
        public List<Product> GetAllProductsByAudienceType(string audienceType);
        public List<Product> GetAllProductsByAudienceAndClothingType(string audienceType, string clothingType);
        public List<Product> GetAllProductsByAudienceAndSize(string audienceType, string size);
        public List<Product> GetAllProductsByAudienceClothingTypeAndSize(string audienceType, string clothingType, string size);
        public Product GetIndividualProduct(string product);
    }
}