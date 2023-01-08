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
    }
}