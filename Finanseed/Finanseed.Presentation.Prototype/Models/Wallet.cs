using System.Collections.Generic;

namespace Finanseed.Presentation.Prototype.Models
{
    public class Wallet
    {
        public float RealBalance { get; set; }
        public float CurrentBalance { get; set; }
        public IEnumerable<IFinanceTransaction> InputTransactions { get; set; }
        public IEnumerable<IFinanceTransaction> OutputTransactions { get; set; }
        public IEnumerable<Bag> Bags { get; set; }
        public IEnumerable<CreditCard> CreditCards { get; set; }
        public int OwnerID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}