using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finanseed.Presentation.Areas.Dashboard.Models.Wallet
{
    public class WalletViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        //public ICollection<Earning> Earnings { get; set; }
        //public ICollection<Spent> Spending { get; set; }
        public Guid OwnerID { get; set; }
        //public virtual User Owner { get; set; }
    }
}