using System;

namespace orenji_backend.Common.Models.ApiModels
{
    public class ApiProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }
        public string AudienceType { get; set; }
        public string Size { get; set; }

        public ApiProduct()
        {
            
        }

        public ApiProduct(string name, string type, string company, double price, string audienceType, string size)
        {
            Name = name;
            Type = type;
            Company = company;
            Price = price;
            AudienceType = audienceType;
            Size = size;
        }
    }
}