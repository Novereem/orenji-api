using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace orenji_backend.Common.Models
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Size { get; set; }
        public string Role { get; set; }

        public Account()
        {
            
        }

        public Account(string firstName, string lastName, string password, string email, string phoneNumber, string size, string role)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            Size = size;
            Role = role;
        }
        
        public Account(string id, string firstName, string lastName, string password, string email, string phoneNumber, string size, string role)
        {
            Id = Guid.Parse(id);
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            Size = size;
            Role = role;
        }
    }
}