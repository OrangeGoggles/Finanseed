using Finanseed.Domain.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Finanseed.Domain.Tests.Commands
{
    [TestClass]
    public class RegisterWalletCommandTest
    {
        [TestMethod]
        [TestCategory("Wallet - new Wallet")]
        public void GivenAnInvalidNameShouldReturnANotification()
        {
            var cmd = new RegisterWalletCommand()
            {
                Name = ""
            };
            cmd.Validate();
            Assert.IsFalse(cmd.Valid);
        }
    }
}