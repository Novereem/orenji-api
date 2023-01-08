using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Logic
{
    public class AccountService
    {
        private readonly IAccountData _accountData;

        //You assume that every field has been filled in with the login an register form as that can be better handled by the fronted for a quicker and easier response
        public AccountService(IAccountData accountData)
        {
            _accountData = accountData;
        }
        public object GetAccountWithLogin(ApiAccount apiAccount)
        {
            Account account = _accountData.GetAccountWithLogin(apiAccount);
            return account;
        }
        
        public object GetAccountWithRegister(ApiAccount apiAccount)
        {
            var newAccount = new Account(apiAccount.FirstName, apiAccount.LastName, apiAccount.Password, apiAccount.Email,apiAccount.PhoneNumber, apiAccount.Size);
            return _accountData.RegisterAccount(newAccount);
        }

        public object GetAccount(ApiAccount apiAccount)
        {
            return _accountData.GetAccount(apiAccount);
        }
    }
}