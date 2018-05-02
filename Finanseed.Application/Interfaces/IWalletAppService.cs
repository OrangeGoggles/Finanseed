using System;
using Finanseed.Application.ViewModels;

namespace Finanseed.Application.Interfaces
{
    public interface IWalletAppService
    {
        WalletViewModel GetByID(Guid walletId);
        void Register(WalletViewModel model);
    }
}