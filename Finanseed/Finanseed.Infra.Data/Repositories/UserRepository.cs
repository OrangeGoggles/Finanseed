using Finanseed.Domain.Entities;
using Finanseed.Domain.Repositories;
using Finanseed.Infra.Data.Context;

namespace Finanseed.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(FinanseedContext db) : base(db)
        {
        }
    }
}
