using System;
using Finanseed.Domain.Entities;

namespace Finanseed.Domain.Repositories
{
    public interface IUserRepository
    {
        User Save(User user);
        bool EmailExists(string address);
        User GetById(Guid userId);
    }
}