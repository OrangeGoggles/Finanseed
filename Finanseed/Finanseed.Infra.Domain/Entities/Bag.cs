using System;

namespace Finanseed.Domain.Entities
{
    public class Bag
    {
        public Bag()
        {
            this.BagID = Guid.NewGuid();
        }
        public Guid BagID { get; set; }
        public float Limit { get; set; }
        public float Balance { get; set; }
        public Guid WalletID { get; set; }
        public virtual Wallet Wallet { get; set; }
    }
}