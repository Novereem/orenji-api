using System.Collections.Generic;
using System.Linq;
using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Data
{
    public class ProductData : IProductData
    {
        private readonly IOrenjiContext _orenjiContext;
        
        public ProductData(IOrenjiContext orenjiContext)
        {
            _orenjiContext = orenjiContext;
        }
        
        List<Product> IProductData.GetAllProductsByAudienceType(string audienceType)
        {
            return _orenjiContext.Product.Where(x => x.AudienceType == audienceType).ToList();
        }

        List<Product> IProductData.GetAllProductsByAudienceAndClothingType(string audienceType, string clothingType)
        {
            return _orenjiContext.Product.Where(x => x.AudienceType == audienceType && x.Type == clothingType).ToList();
        }

        public List<Product> GetAllProductsByAudienceAndSize(string audienceType, string size)
        {
            return _orenjiContext.Product.Where(x => x.AudienceType == audienceType && x.Size == size).ToList();
        }

        public List<Product> GetAllProductsByAudienceClothingTypeAndSize(string audienceType, string clothingType, string size)
        {
            return _orenjiContext.Product.Where(x => x.AudienceType == audienceType && x.Type == clothingType && x.Size == size).ToList();
        }

        public Product GetIndividualProduct(string productId)
        {
            return _orenjiContext.Product.First(x => x.Id.ToString() == productId);
        }
    }
}