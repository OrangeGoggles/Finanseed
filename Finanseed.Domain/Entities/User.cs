using System.Collections.Generic;
using System.Linq;
using Finanseed.Domain.Base;
using Finanseed.Domain.ValueObjects;

namespace Finanseed.Domain.Entities
{
    public class User : Entity
    {
        private IList<Wallet> _wallets = new List<Wallet>();
        public User(Name name, Email email, Password password)
        {
            Name = name;
            Email = email;
            Password = password;
            _wallets.Add(new Wallet("Principal"));
            AddNotifications(Name, Email, Password);
            Active = false;
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyList<Wallet> Wallets { get{ return _wallets.ToList(); } }
        public void Activate() => Active = true;

        public void AddWallet(Wallet wallet){
            if(wallet.Valid){
                _wallets.Add(wallet);
            }
        }
        public void AddWallets(IEnumerable<Wallet> wallets){
            foreach (var wallet in wallets)
            {
                AddWallet(wallet);
            }
        }
    }
}