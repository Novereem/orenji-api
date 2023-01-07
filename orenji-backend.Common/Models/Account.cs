﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace orenji_backend.Common.Models
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Product> LikedProducts { get; set; }
    }
}