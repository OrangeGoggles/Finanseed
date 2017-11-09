using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Finanseed.Domain.Services
{
    public interface IServiceBase<T> where T : class 
    {
        T Add(T obj);
        void Update(T obj);
        void Remove(Guid id);
        T Get(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Expression<Func<T, bool>> expression);
    }
}
