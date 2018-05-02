using System;
using Finanseed.Domain.Entities;
using Finanseed.Domain.Repositories;
using Finanseed.Infra.Context;

namespace Finanseed.Infra.Repositories
{
    public class WalletRepository : Repository, IWalletRepository
    {
        public WalletRepository(FinanseedDataContext db) : base(db)
        {
        }

        public Wallet GetById(Guid Id)
        {
            return db.Set<Wallet>().Find(Id);
        }

        public void Save(Wallet wallet)
        {
            db.Set<Wallet>().Add(wallet);
            db.SaveChanges();
        }
    }
}