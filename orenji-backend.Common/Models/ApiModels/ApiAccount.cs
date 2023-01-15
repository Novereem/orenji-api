using System;

namespace orenji_backend.Common.Models.ApiModels
{
    public class ApiAccount
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Size { get; set; }
        public string Role { get; set; }

        public ApiAccount()
        {
            
        }
        public ApiAccount(string id, string firstName, string lastName, string password, string email, string phoneNumber, string size, string role)
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
        public ApiAccount(string firstName, string lastName, string password, string email, string phoneNumber, string size, string role)
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
    }
}