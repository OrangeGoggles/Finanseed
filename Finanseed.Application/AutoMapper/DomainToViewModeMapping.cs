using AutoMapper;
using Finanseed.Application.ViewModels;
using Finanseed.Domain.Entities;
using Finanseed.Domain.Results;

namespace Finanseed.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserResult, UserViewModel>();
            CreateMap<Wallet, WalletViewModel>();
        }
    }
}
