using orenji_backend.Common.Interfaces;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Tests.FakeData
{
    public class FakeAccountData : IAccountData
    {
        public Account GetAccountWithLogin(ApiAccount apiAccount)
        {
            if (apiAccount.Password == "a")
            {
                return new Account("John", "Doe", "a", "a@a.com", "0612345678", SizeTypes.M.ToString(), "User");
            }

            return null;
        }

        public Account RegisterAccount(Account account)
        {
            return account;
        }
    }
}