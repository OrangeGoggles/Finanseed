using Finanseed.Domain.ValueObject;
using System;
using System.Collections.Generic;

namespace Finanseed.Domain.Entities
{
    public class User : EntityBase
    {
        public User()
        {
            ID = Guid.NewGuid();
            base.CreationDate = DateTime.Now;
        }
        public Guid ID { get; set; }
        public DateTime Birthday { get; set; }
        public int AccessFailedCount { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
