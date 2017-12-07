using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Finanseed.Domain.Entities.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        [TestCategory("User - New User")]
        public void GivenANewUserTheUserShouldIsDeactivatedEmailNotConfirmedPhoneNumberConfirmed()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            Assert.IsFalse(user.Active);
            Assert.IsFalse(user.EmailConfirmed);
            Assert.IsFalse(user.PhoneNumberConfirmed);
        }

        [TestMethod()]
        [TestCategory("User - Confirmations")]
        public void GivenAConfirmedEmailTheUserShouldIsEmailConfirmed()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            user.ConfirmEmail();
            Assert.IsTrue(user.EmailConfirmed);
        }

        [TestMethod()]
        [TestCategory("User - Confirmations")]
        public void GivenAConfirmedPhoneNumberTheUserShouldIsPhoneNumberConfirmed()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            user.ConfirmPhoneNumber();
            Assert.IsTrue(user.PhoneNumberConfirmed);
        }

        [TestMethod()]
        [TestCategory("User - Confirmations")]
        public void GivenAActivatedUserTheUserShouldIsActive()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            user.Activate();
            Assert.IsTrue(user.Active);
        }

        [TestMethod()]
        [TestCategory("User - Atuhentication")]
        public void GivenAValidUsernameAndPasswordTheUserShouldIsAthenticated()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            var result = user.Authenticate("vpcmps@gmail.com", "vpcmps");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        [TestCategory("User - Atuhentication")]
        public void GivenAInvalidUsernameAndPasswordThreeTimesTheUserShouldIsDeactivated()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            var result = user.Authenticate("teste", "123");
            result = user.Authenticate("teste", "123");
            result = user.Authenticate("teste", "123");
            Assert.IsFalse(user.Active);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        [TestCategory("User - New User")]
        public void GivenAnInvalidUserNameShouldReturnANotification()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcampos@gmail.com", "vpcmps", "+5561994544774", "");
            Assert.IsFalse(user.IsValid());
        }

        [TestMethod()]
        [TestCategory("User - New User")]
        public void GivenAnInvalidEmailShouldReturnANotification()
        {
            var user = new User(new DateTime(1995, 10, 11), "v", "vpcmps", "+5561994544774", "ViniciusCampos");
            Assert.IsFalse(user.IsValid());
        }

        [TestMethod()]
        [TestCategory("User - New User")]
        public void GivenAValidUserShouldNotReturnANotification()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            Assert.IsTrue(user.IsValid());
        }
    }
}