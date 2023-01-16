using NUnit.Framework;
using NUnit.Framework.Internal;
using orenji_backend.Common.Models;
using orenji_backend.Common.Models.ApiModels;
using orenji_backend.Logic;
using orenji_backend.Tests.FakeData;

namespace orenji_backend.Tests.IntegrationTests
{
    public class AccountServiceTests
    {
        private readonly AccountService _accountService;

        public AccountServiceTests()
        {
            _accountService = new AccountService(new FakeAccountData());
        }
        
        [Test]
        public void Test_GetAccountWithLogin_True()
        {
            var apiAccount = new ApiAccount("John", "Doe", "a", "a@a.com", "0612345678", SizeTypes.M.ToString(), "User");
            Assert.True(_accountService.GetAccountWithLogin(apiAccount) != "");
        }
        [Test]
        public void Test_GetAccountWithLogin_False()
        {
            var apiAccount = new ApiAccount("John", "Doe", "b", "a@a.com", "0612345678", SizeTypes.M.ToString(), "User");
            Assert.False(_accountService.GetAccountWithLogin(apiAccount) != "");
        }

        [Test]
        public void Test_GetAccountWithRegister_True()
        {
            var apiAccount = new ApiAccount("John", "Doe", "a", "a@a.com", "0612345678", SizeTypes.M.ToString(), "User");
            Assert.True(_accountService.GetAccountWithRegister(apiAccount) != "");
        }
    }
}