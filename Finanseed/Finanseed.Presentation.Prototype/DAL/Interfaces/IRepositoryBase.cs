using System.Collections.Generic;

namespace Finanseed.Presentation.Prototype.DAL.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        T Add(T obj);

        void Update(T obj);

        void Remove(T obj);

        T GetByID(int id);

        IEnumerable<T> GetAll();

        void Dispose();
    }
}