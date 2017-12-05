using System;
using System.Collections.Generic;

namespace Finanseed.Domain.Entities
{
    public class User : EntityBase
    {
        public User(DateTime birthday, string email, string passwordHash, string phoneNumber, string userName)
        {
            Birthday = birthday;
            Email = email;
            PasswordHash = passwordHash;
            PhoneNumber = phoneNumber;
            UserName = userName;
            ID = Guid.NewGuid();
            CreationDate = DateTime.Now;
            Wallets = new List<Wallet>();
            EmailConfirmed = false;
            PhoneNumberConfirmed = false;
            AccessFailedCount = 0;
            Active = false;
        }

        public Guid ID { get; set; }

        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Wallet> Wallets { get; set; }

        public bool EmailConfirmed { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public int AccessFailedCount { get; set; }
        public bool Active { get; private set; }

        public void ConfirmEmail()
        {
            EmailConfirmed = true;
        }

        public void ConfirmPhoneNumber()
        {
            PhoneNumberConfirmed = true;
        }

        public void AccessFailed()
        {
            if (AccessFailedCount < 3)
                AccessFailedCount++;
            else
                Deactivate();
        }

        public void Activate()
        {
            Active = true;
        }

        private void Deactivate()
        {
            Active = false;
        }

        public void AddWallet(Wallet wallet)
        {
            wallet.OwnerID = ID;
            Wallets.Add(wallet);
        }
    }
}
