using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication2.Services;

namespace WebApplication2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestClass]
        public class UserService_IsPrimeShould
        {
            private readonly UserService _userService;

            public UserService_IsPrimeShould()
            {
                _userService = new UserService();
            }

            [TestMethod]
            public void ReturnFalseGivenValueOf1()
            {
                var result = _userService.IsPrime(1);

                Assert.IsFalse(result, "1 should not be prime");
            }
        }
    }
}
