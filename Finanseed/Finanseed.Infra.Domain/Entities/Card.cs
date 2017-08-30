using System;

namespace Finanseed.Domain.Entities
{
    public class Card
    {
        public float Limit { get; set; }
        public float Balance { get; set; }
        public DateTime DueDate { get; set; }
        public Guid WalletID { get; set; }
        public virtual Wallet Wallet { get; set; }

    }
}