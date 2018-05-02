using Finanseed.Domain.Entities;
using Finanseed.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Finanseed.Domain.Tests.Entities
{
    [TestClass]
    public class FinancialTransactionTests
    {
        [TestMethod]
        [TestCategory("Transaction Category - new Transaction Category")]
        public void GivenAnInvalidNameShouldReturnANotification()
        {
            var transactionCategory = new TransactionCategory("Supermercado", ETransactionType.Out);
            var transaction = new FinancialTransaction("", 5, ETransactionRecursion.Monthly, transactionCategory);
            Assert.IsFalse(transaction.Valid);
        }

        [TestMethod]
        [TestCategory("Transaction Category - new Transaction Category")]
        public void GivenAnInvalidValueShouldReturnANotification()
        {
            var transactionCategory = new TransactionCategory("Supermercado", ETransactionType.Out);
            var transaction = new FinancialTransaction("Compra do Mês", 0, ETransactionRecursion.Monthly, transactionCategory);
            Assert.IsFalse(transaction.Valid);
        }
    }
}