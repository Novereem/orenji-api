using System.Linq;
using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Data
{
    public class AccountData : IAccountData
    {
        private readonly IOrenjiContext _orenjiContext;
        
        public AccountData(IOrenjiContext orenjiContext)
        {
            _orenjiContext = orenjiContext;
        }
        public Account GetAccountWithLogin(ApiAccount apiAccount)
        {
            return _orenjiContext.Account.FirstOrDefault(x => x.Email == apiAccount.Email && x.Password == apiAccount.Password);
        }

        public Account RegisterAccount(Account account)
        {
            _orenjiContext.Account.Add(account);
            _orenjiContext.SaveChanges();
            return _orenjiContext.Account.FirstOrDefault(x => x.Email == account.Email && x.Password == account.Password);
        }
    }
}