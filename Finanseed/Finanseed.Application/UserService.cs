using Finanseed.Domain.Services;
using System;
using System.Collections.Generic;
using Finanseed.Domain.Entities;
using Finanseed.Domain.Repositories;
using System.Linq.Expressions;
using System.Linq;

namespace Finanseed.Application
{
    public class UserService : IUserService
    {
        #region [Properties]
        protected IUserRepository UserRepository;
        #endregion

        #region [Constructor]
        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }
        #endregion

        #region [Methods]
        public User Add(User obj)
        {
            return UserRepository.Add(obj);
        }

        public User Authenticate(string email, string password)
        {
            return UserRepository.Get(
                x =>
                x.Email == email &&
                x.PasswordHash == password).FirstOrDefault();
        }

        public User Get(Guid id)
        {
            return UserRepository.Get(id);
        }

        public IEnumerable<User> Get(Expression<Func<User, bool>> expression)
        {
            return UserRepository.Get(expression);
        }

        public IEnumerable<User> GetAll()
        {
            return UserRepository.GetAll();
        }

        public void Remove(Guid id)
        {
            UserRepository.Get(id);
        }

        public void Update(User obj)
        {
            UserRepository.Update(obj);
        }
        #endregion
    }
}
