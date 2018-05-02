using System;
using System.Linq;
using Finanseed.Domain.Entities;
using Finanseed.Domain.Queries;
using Finanseed.Domain.Repositories;
using Finanseed.Infra.Context;

namespace Finanseed.Infra.Repositories
{
    public class UserRepository : Repository, IUserRepository
    {
        public UserRepository(FinanseedDataContext db) : base(db)
        {
        }

        public bool EmailExists(string address) => db.Set<User>().Any(UserQuery.EmailEquals(address));

        public User GetById(Guid userId)
        {
            return db.Set<User>().Find(userId);
        }

        public User Save(User user)
        {
            var userEntity = db.Set<User>().Add(user);
            db.SaveChanges();
            return userEntity.Entity;
        }
    }
}