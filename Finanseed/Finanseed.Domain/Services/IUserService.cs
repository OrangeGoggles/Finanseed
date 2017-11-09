using Finanseed.Domain.Entities;

namespace Finanseed.Domain.Services
{
    public interface IUserService : IServiceBase<User>
    {
        User Authenticate(string email, string password);
    }
}
