using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
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
        
        public AccountController(OrenjiContext orenjiContext)
        {
            _accountService = new AccountService(new AccountData(orenjiContext));
        }

        [HttpPost("/login")]
        public object LoginRequest([FromBody]ApiAccount apiAccount)
        {
            return _accountService.GetAccountWithLogin(apiAccount);
        }

        [HttpPost("/register/")]
        public object RegisterRequest([FromBody]ApiAccount apiAccount)
        {
            return _accountService.GetAccountWithRegister(apiAccount);
        }
        
        [HttpPost("/profile/")]
        public object GetAccount([FromBody]ApiAccount apiAccount)
        {
            return _accountService.GetAccount(apiAccount);
        }
    }
}