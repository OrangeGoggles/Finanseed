using System;
using AutoMapper;
using Finanseed.Application.Interfaces;
using Finanseed.Application.ViewModels;
using Finanseed.Domain.Repositories;

namespace Finanseed.Application.Services
{
    public class WalletAppService : IWalletAppService
    {
        public readonly IWalletRepository _repository;
        public readonly IMapper _mapper;

        public WalletAppService(IWalletRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public WalletViewModel GetByID(Guid walletId)
        {
            throw new NotImplementedException();
        }

        public void Register(WalletViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}