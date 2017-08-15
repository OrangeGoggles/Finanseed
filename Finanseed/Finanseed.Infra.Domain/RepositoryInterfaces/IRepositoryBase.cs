using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Finanseed.Domain.RepositoryInterfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class 
    {
        TEntity Add(TEntity obj);
        void Delete(TEntity obj);
        void Update(TEntity obj);
        TEntity GetByID(int id);
        IEnumerable<TEntity> GetAll();
        Task<TEntity> AddAsync(TEntity obj);
        Task DeleteAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
        Task<TEntity> GetByID(TEntity obj);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
