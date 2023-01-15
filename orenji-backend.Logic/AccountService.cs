using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Logic
{
    public class AccountService
    {
        private readonly IAccountData _accountData;
        private readonly AuthenticationService _authenticationService;

        //You assume that every field has been filled in with the login an register form as that can be better handled by the fronted for a quicker and easier response
        public AccountService(IAccountData accountData)
        {
            _accountData = accountData;
            _authenticationService = new AuthenticationService();
        }
        
        public string GetAccountWithLogin(ApiAccount apiAccount) 
        {
            Account account = _accountData.GetAccountWithLogin(apiAccount);
            return _authenticationService.GenerateToken(account, new Jwt());
        }
        
        public string GetAccountWithRegister(ApiAccount apiAccount)
        {
            var newAccount = new Account(apiAccount.FirstName, apiAccount.LastName, apiAccount.Password, apiAccount.Email,apiAccount.PhoneNumber, apiAccount.Size, "User");
            return _authenticationService.GenerateToken(_accountData.RegisterAccount(newAccount), new Jwt());
        }

        public object GetAccount(ApiAccount apiAccount)
        {
            return _accountData.GetAccount(apiAccount);
        }

        
    }
}