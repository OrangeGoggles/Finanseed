using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Finanseed.Domain.Repositories
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        T Add(T obj);
        void Update(T obj);
        void Remove(Guid id);
        T Get(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T obj);
        Task UpdateAsync(T obj);
        Task RemoveAsync(Guid id);
        Task<T> GetAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> expression);
    }
}
