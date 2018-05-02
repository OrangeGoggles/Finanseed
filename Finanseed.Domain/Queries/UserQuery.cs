using System;
using System.Linq.Expressions;
using Finanseed.Domain.Entities;

namespace Finanseed.Domain.Queries
{
    public static class UserQuery 
    {
        
        public static Expression<Func<User,bool>> EmailEquals(string address) => x => x.Email.Address == address;
    }
}