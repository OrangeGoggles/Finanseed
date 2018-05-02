using Finanseed.Domain.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Finanseed.Domain.Tests.Commands
{
    [TestClass]
    public class RegisterUserCommandTest
    {
        [TestMethod]
        [TestCategory("User - new User")]
        public void GivenAnInvalidFirstNameShouldReturnANotification()
        {
            var cmd = new RegisterUserCommand(){
                FirstName = "", 
                LastName = "Campos",
                Address = "vpcmps@gmail.com",
                Pwd = "Vin1ciusPC"
            };
            cmd.Validate();
            Assert.IsFalse(cmd.Valid);
        }

        [TestMethod]
        [TestCategory("User - new User")]
        public void GivenAnInvalidLastNameShouldReturnANotification()
        {
            var cmd = new RegisterUserCommand(){
                FirstName = "Vinicius", 
                LastName = "",
                Address = "vpcmps@gmail.com",
                Pwd = "Vin1ciusPC"
            };
            cmd.Validate();
            Assert.IsFalse(cmd.Valid);
        }

        [TestMethod]
        [TestCategory("User - new User")]
        public void GivenAnInvalidEmailShouldReturnANotification()
        {
            var cmd = new RegisterUserCommand(){
                FirstName = "Vinicius", 
                LastName = "Campos",
                Address = "vpcmpsgmailcom",
                Pwd = "Vin1ciusPC"
            };
            cmd.Validate();
            Assert.IsFalse(cmd.Valid);
        }

        [TestMethod]
        [TestCategory("User - new User")]
        public void GivenAnInvalidPasswordShouldReturnANotification()
        {
            var cmd = new RegisterUserCommand(){
                FirstName = "Vinicius", 
                LastName = "Campos",
                Address = "vpcmps@gmail.com",
                Pwd = "viniciuspc"
            };
            cmd.Validate();
            Assert.IsFalse(cmd.Valid);
        }

        [TestMethod]
        [TestCategory("User - new User")]
        public void GivenAValidEntryShouldNotReturnANotification()
        {
            var cmd = new RegisterUserCommand(){
                FirstName = "Vinicius", 
                LastName = "Campos",
                Address = "vpcmps@gmail.com",
                Pwd = "Vin1ciusPC"
            };
            cmd.Validate();
            Assert.IsTrue(cmd.Valid);
        }
    }
}