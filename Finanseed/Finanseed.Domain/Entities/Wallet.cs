using Finanseed.Domain.Common;
using System;
using System.Collections.Generic;

namespace Finanseed.Domain.Entities
{
    public class Wallet : EntityBase
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        //public ICollection<Earning> Earnings { get; set; }
        //public ICollection<Spent> Spending { get; set; }
        public Guid OwnerID { get; set; }
        public virtual User Owner { get; set; }
    }
}
