using System;
using System.ComponentModel.DataAnnotations;

namespace orenji_backend.Common.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }
        public string AudienceType { get; set; }
        public string Size { get; set; }

        public Product()
        {
            
        }

        public Product(string name, string type, string company, double price, string audienceType, string size)
        {
            Id = Guid.NewGuid();
            Name = name;
            Type = type;
            Company = company;
            Price = price;
            AudienceType = audienceType;
            Size = size;
        }
        
        public Product(Guid id, string name, string type, string company, double price, string audienceType, string size)
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