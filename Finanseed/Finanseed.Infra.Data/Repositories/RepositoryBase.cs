using Finanseed.Domain.Repositories;
using Finanseed.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Finanseed.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected FinanseedContext DB;
        public RepositoryBase(FinanseedContext db)
        {
            DB = db;
        }
        public T Add(T obj)
        {
            var response = DB.Set<T>().Add(obj);
            DB.SaveChanges();
            return response.Entity;
        }

        public async Task<T> AddAsync(T obj)
        {
            var response = DB.Set<T>().Add(obj);
            await DB.SaveChangesAsync();
            return response.Entity;
        }

        public void Dispose()
        {
            DB.Dispose();
        }

        public T Get(Guid id)
        {
            return DB.Set<T>().Find(id);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> expression)
        {
            return DB.Set<T>().Where(expression).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return DB.Set<T>().ToList();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetAsync(Guid id)
        {
            return await DB.Set<T>().FindAsync(id);
        }

        public Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            T entity = Get(id);
            if (entity != null)
            {
                DB.Set<T>().Remove(entity);
                DB.SaveChanges();
            }
        }

        public async Task RemoveAsync(Guid id)
        {
            var entity = await GetAsync(id);

            if (entity != null)
            {
                DB.Set<T>().Remove(entity);
                await DB.SaveChangesAsync();
            }
        }

        public void Update(T obj)
        {
            DB.Entry(obj).State = EntityState.Modified;
            DB.SaveChanges();
        }

        public async Task UpdateAsync(T obj)
        {
            DB.Entry(obj).State = EntityState.Modified;
            await DB.SaveChangesAsync();
        }
    }
}
