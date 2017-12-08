using Finanseed.Domain.Common;
using FluentValidator;
using System;
using System.Collections.Generic;

namespace Finanseed.Domain.Entities
{
    public class User : EntityBase
    {
        public User(DateTime birthday, 
            string email, 
            string passwordHash, 
            string phoneNumber, 
            string userName)
        {
            Birthday = birthday;
            Email = email;
            SetPassword(passwordHash);
            PhoneNumber = phoneNumber;
            UserName = userName;
            CreationDate = DateTime.Now;
            Wallets = new List<Wallet>();
            EmailConfirmed = false;
            PhoneNumberConfirmed = false;
            AccessFailedCount = 0;
            Active = false;

            new ValidationContract<User>(this)
                .IsRequired(x => x.UserName)
                .HasMaxLenght(x => x.UserName, 60)
                .HasMinLenght(x => x.UserName, 3)
                .IsEmail(x => x.Email);
        }

        #region [Properties]
        public DateTime Birthday { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public string PhoneNumber { get; private set; }
        public string UserName { get; private set; }
        public virtual ICollection<Wallet> Wallets { get; private set; }
        public bool EmailConfirmed { get; private set; }
        public bool PhoneNumberConfirmed { get; private set; }
        public int AccessFailedCount { get; private set; }
        public bool Active { get; private set; }
        #endregion

        #region [Methods]
        public void ConfirmEmail() => EmailConfirmed = true;

        public void Activate() => Active = true;

        private void Deactivate() => Active = false;

        private void SetPassword(string password) => this.PasswordHash = password;

        public bool Authenticate(string email, string password)
        {
            if (email == this.Email && password == this.PasswordHash)
                return true;
            else
            {
                AccessFailed();
                return false;
            }

        }

        public void ConfirmPhoneNumber()
        {
            PhoneNumberConfirmed = true;
        }

        private void AccessFailed()
        {
            if (AccessFailedCount < 3)
                AccessFailedCount++;
            else
                Deactivate();
        }

        public void AddWallet(Wallet wallet)
        {
            wallet.OwnerID = Id;
            Wallets.Add(wallet);
        } 
        #endregion
    }
}
