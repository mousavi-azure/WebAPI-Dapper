using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
