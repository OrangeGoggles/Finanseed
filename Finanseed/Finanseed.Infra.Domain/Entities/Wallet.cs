using System;
using System.Collections.Generic;

namespace Finanseed.Domain.Entities
{
    public class Wallet
    {
        public Wallet()
        {
            WalletID = Guid.NewGuid();
        }
        public Guid WalletID { get; set; }
        public float RealBalance { get; set; }
        public float CurrentBalance { get; set; }
        public virtual IEnumerable<FinancialTransaction> FinancialTransactions { get; set; }
        public virtual IEnumerable<Bag> Bags { get; set; }
        public virtual IEnumerable<Card> CreditCards { get; set; }
        public Guid OwnerID { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }
    }
}