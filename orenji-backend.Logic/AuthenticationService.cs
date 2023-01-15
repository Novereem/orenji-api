using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Logic
{
    public class AuthenticationService
    {
        public AuthenticationService()
        {
            
        }
        
        public Account TokenToAccount(ClaimsIdentity identity)
        {
            if (identity != null)
            {
                var accountClaims = identity.Claims;

                return new Account(
                    accountClaims.FirstOrDefault(x => x.Type == "Id")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "FirstName")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "LastName")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "Password")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "Email")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "PhoneNumber")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "Size")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "Role")?.Value
                );
            }

            return null;
        }
        
        public ApiAccount TokenToApiAccount(ClaimsIdentity identity)
        {
            if (identity != null)
            {
                var accountClaims = identity.Claims;

                return new ApiAccount(
                    accountClaims.FirstOrDefault(x => x.Type == "Id")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "FirstName")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "LastName")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "Password")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "Email")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "PhoneNumber")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "Size")?.Value,
                    accountClaims.FirstOrDefault(x => x.Type == "Role")?.Value
                );
            }

            return null;
        }
        
        
        
        public string GenerateToken(Account account, Jwt jwt)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("Id", account.Id.ToString()),
                new Claim("FirstName", account.FirstName),
                new Claim("LastName", account.LastName),
                new Claim("Password", ""),
                new Claim("Email", account.Email),
                new Claim("PhoneNumber", account.PhoneNumber),
                new Claim("Size", account.Size),
                new Claim("Role", account.Role),
            };

            var token = new JwtSecurityToken(jwt.Issuer,
                jwt.Audience,
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}