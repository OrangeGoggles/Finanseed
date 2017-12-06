using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Finanseed.Domain.Entities.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void UserTest()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            Assert.IsFalse(user.Active);
            Assert.IsFalse(user.EmailConfirmed);
            Assert.IsFalse(user.PhoneNumberConfirmed);
        }

        [TestMethod()]
        public void ConfirmEmailTest()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            user.ConfirmEmail();
            Assert.IsTrue(user.EmailConfirmed);
        }

        [TestMethod()]
        public void ConfirmPhoneNumberTest()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            user.ConfirmPhoneNumber();
            Assert.IsTrue(user.PhoneNumberConfirmed);
        }

        [TestMethod()]
        public void ActivateTest()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            user.Activate();
            Assert.IsTrue(user.Active);
        }

        [TestMethod()]
        public void AuthenticateTest()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            var result = user.Authenticate("vpcmps@gmail.com", "vpcmps");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void AuthenticateFailedTest()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            var result = user.Authenticate("teste", "123");
            result = user.Authenticate("teste", "123");
            result = user.Authenticate("teste", "123");
            Assert.IsFalse(user.Active);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void UserInvalidTest()
        {
            var user = new User(new DateTime(1995, 10, 11), "v", "vpcmps", "+5561994544774", "V");
            Assert.IsFalse(user.IsValid());
        }

        [TestMethod()]
        public void UserValidTest()
        {
            var user = new User(new DateTime(1995, 10, 11), "vpcmps@gmail.com", "vpcmps", "+5561994544774", "Vinicius Campos");
            Assert.IsTrue(user.IsValid());
        }
    }
}