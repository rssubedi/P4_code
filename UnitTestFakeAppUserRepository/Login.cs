using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3_code;

namespace UnitTestFakeAppUserRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {

            const string User_Name = "rajeepsubedi";
            const string PASSWORD = "password";
            FakeAppUserRespository UsrRepository = new FakeAppUserRespository();

            bool result = UsrRepository.Login(User_Name, PASSWORD);
            Assert.IsTrue(result);
            
        }

        public void LoginWithIncorrectCredentialsFail()
        {
            const string User_Name = "Test";
            const string PASSWORD = "Case";
            FakeAppUserRespository UsrRepository = new FakeAppUserRespository();

            bool result = UsrRepository.Login(User_Name, PASSWORD);
            Assert.IsFalse(result);
        }
    }
}
