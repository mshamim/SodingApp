using System.Collections.Generic;

namespace SodingApp.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        void SoftDeleteAndSubmit(T entity);
        void DeleteAndSubmit(T entity);
        IEnumerable<T> GetAll();
        void UpdateAndSubmit(T entity);
        void InsertAndSubmit(T entity);
        T GetById(int id);
    }
}