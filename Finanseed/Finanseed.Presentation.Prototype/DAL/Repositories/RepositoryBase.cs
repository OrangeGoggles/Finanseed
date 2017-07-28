using Finanseed.Presentation.Prototype.DAL.Context;
using Finanseed.Presentation.Prototype.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Finanseed.Presentation.Prototype.DAL.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T>, IDisposable where T : class
    {
        internal FinanSeedContext Db = new FinanSeedContext();
        public T Add(T obj)
        {
            obj = Db.Set<T>().Add(obj);
            Db.SaveChanges();
            return obj;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return Db.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public void Remove(T obj)
        {
            Db.Set<T>().Remove(obj);
        }

        public void Update(T obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}