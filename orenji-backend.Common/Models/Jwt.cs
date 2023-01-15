using System;

namespace orenji_backend.Common.Models
{
    public class Jwt
    {
        public string Key { get; set; } = "XK2K8tRf2p3MO33zhpttzFN9MLEkl7S7LGdSDGMB";
        public string Issuer { get; set; } = "https://localhost:44353";
        public string Audience { get; set; } = "https://localhost:44353";
    }
}