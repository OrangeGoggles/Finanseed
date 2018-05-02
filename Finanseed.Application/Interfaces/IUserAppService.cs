using System;
using Finanseed.Application.ViewModels;

namespace Finanseed.Application.Interfaces
{
    public interface IUserAppService : IDisposable
    {
        UserViewModel GetUser(Guid userId);
        UserViewModel RegisterUser(UserViewModel registerViewModel);
    }
}