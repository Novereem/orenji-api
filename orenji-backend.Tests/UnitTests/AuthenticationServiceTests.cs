using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using NUnit.Framework;
using orenji_backend.Common.Models;
using orenji_backend.Logic;

namespace orenji_backend.Tests.UnitTests
{
    public class AuthenticationServiceTests
    {
        private readonly AuthenticationService _authenticationService;

        public AuthenticationServiceTests()
        {
            _authenticationService = new AuthenticationService();
        }

        [Test]
        public void Test_GenerateToken_True()
        {
            var account = new Account("John", "Doe", "a", "a@a.com", "0612345678", SizeTypes.M.ToString(), "User");
            var jwt = new Jwt();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
            
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = key,
                ValidateLifetime = true,
                ValidateAudience = true,
                ValidAudience = jwt.Audience,
                ValidateIssuer = true,
                ValidIssuer = jwt.Issuer
            };

            var handler = new JwtSecurityTokenHandler();
            if (handler.ValidateToken(_authenticationService.GenerateToken(account, jwt), validationParameters, out SecurityToken validatedToken).Claims.ToString()!
                .Contains("John"))
            {
                Assert.True(true);
            }
            Assert.False(false);
        }
    }
}