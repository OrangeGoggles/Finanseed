using System;

namespace Finanseed.Domain.Entities
{
    public class FinancialTransaction
    {
        public FinancialTransaction()
        {
            this.FinancialTransactionID = Guid.NewGuid();
        }
        public Guid FinancialTransactionID { get; set; }
        public float Value { get; set; }
        public string Name { get; set; }
        public DateTime TransactionDate { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public Guid WalletID { get; set; }
        public virtual Wallet Wallet { get; set; }
    }
}