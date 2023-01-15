using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;
using orenji_backend.Data;
using orenji_backend.Logic;

namespace orenji_backend.Controllers
{
    [EnableCors("AllowCors")]
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly AccountService _accountService;
        private readonly AuthenticationService _authenticationService;
        
        public AccountController(OrenjiContext orenjiContext)
        {
            _accountService = new AccountService(new AccountData(orenjiContext));
            _authenticationService = new AuthenticationService();
        }

        [AllowAnonymous]
        [HttpPost("/login")]
        public string LoginRequest([FromBody]ApiAccount apiAccount)
        {
            return _accountService.GetAccountWithLogin(apiAccount);
        }

        [AllowAnonymous]
        [HttpPost("/register/")]
        public string RegisterRequest([FromBody]ApiAccount apiAccount)
        {
            return _accountService.GetAccountWithRegister(apiAccount);
        }
        
        [HttpPost("/profile/")]
        public object GetAccount()
        {
            var account = TokenToAccount();
            return account;
        }
        
        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        private Account TokenToAccount()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            return _authenticationService.TokenToAccount(identity);
        }
    }
}