using System;
using System.Collections.Generic;

namespace Finanseed.Presentation.Prototype.Models
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
        public IEnumerable<IFinanceTransaction> InputTransactions { get; set; }
        public IEnumerable<IFinanceTransaction> OutputTransactions { get; set; }
        public IEnumerable<Bag> Bags { get; set; }
        public IEnumerable<CreditCard> CreditCards { get; set; }
        public Guid OwnerID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}