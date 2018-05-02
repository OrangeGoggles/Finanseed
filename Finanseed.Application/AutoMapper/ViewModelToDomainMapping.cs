using AutoMapper;
using Finanseed.Application.ViewModels;
using Finanseed.Domain.Commands;

namespace Finanseed.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, RegisterUserCommand>()
                .ConstructUsing(c => new RegisterUserCommand(c.FirstName, c.LastName, c.EmailAddress, c.Pwd));
        }
    }
}
