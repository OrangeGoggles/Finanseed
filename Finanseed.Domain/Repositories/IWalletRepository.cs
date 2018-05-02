using System;
using Finanseed.Domain.Entities;

namespace Finanseed.Domain.Repositories
{
    public interface IWalletRepository
    {
        Wallet GetById(Guid Id);
        void Save(Wallet wallet);
    }
}