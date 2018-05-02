using Finanseed.Domain.Entities;
using Finanseed.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Finanseed.Domain.Tests.Entities
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        [TestCategory("User - Activate")]
        public void GivenANewUserShouldBeInactive()
        {
            var name = new Name("Vinicius", "Campos");
            var email = new Email("vpcmps@gmail.com");
            var password = new Password("Vin1ciusPC");
            var user = new User(name, email, password);
            Assert.IsFalse(user.Active);
        }

        [TestMethod]
        [TestCategory("User - Activate")]
        public void WhenActivateAUserTheActiveShouldBeTrue()
        {
            var name = new Name("Vinicius", "Campos");
            var email = new Email("vpcmps@gmail.com");
            var password = new Password("Vin1ciusPC");
            var user = new User(name, email, password);
            user.Activate();
            Assert.IsTrue(user.Active);
        }
    }
}