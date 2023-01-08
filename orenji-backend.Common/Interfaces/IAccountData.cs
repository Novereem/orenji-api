using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;

namespace orenji_backend.Common.Interfaces
{
    public interface IAccountData
    {
        public Account GetAccountWithLogin(ApiAccount apiAccount);
        public Account RegisterAccount(Account account);
        public Account GetAccount(ApiAccount apiAccount);
    }
}