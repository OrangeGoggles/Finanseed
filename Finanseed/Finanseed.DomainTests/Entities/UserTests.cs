using Finanseed.Domain.Entities;
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
    }
}