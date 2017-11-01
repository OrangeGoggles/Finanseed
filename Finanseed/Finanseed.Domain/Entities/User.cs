using Finanseed.Domain.ValueObject;
using System;
using System.Collections.Generic;

namespace Finanseed.Domain.Entities
{
    public class User : EntityBase
    {
        public Guid ID { get; set; }
        public DateTime Birthday { get; set; }
        public int AccessFailedCount { get; set; }
        //
        // Summary:
        //     Email
        public string Email { get; set; }
        //
        // Summary:
        //     True if the email is confirmed, default is false
        public bool EmailConfirmed { get; set; }
        //
        // Summary:
        //     Is lockout enabled for this user
        public bool LockoutEnabled { get; set; }
        //
        // Summary:
        //     DateTime in UTC when lockout ends, any time in the past is considered not locked
        //     out.
        public DateTime? LockoutEndDateUtc { get; set; }
        //
        // Summary:
        //     The salted/hashed form of the user password
        public string PasswordHash { get; set; }
        //
        // Summary:
        //     PhoneNumber for the user
        public string PhoneNumber { get; set; }
        //
        // Summary:
        //     True if the phone number is confirmed, default is false
        public bool PhoneNumberConfirmed { get; set; }
        //
        // Summary:
        //     A random value that should change whenever a users credentials have changed (password
        //     changed, login removed)
        public string SecurityStamp { get; set; }
        //
        // Summary:
        //     Is two factor enabled for the user
        public bool TwoFactorEnabled { get; set; }
        //
        // Summary:
        //     User name
        public string UserName { get; set; }

        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
