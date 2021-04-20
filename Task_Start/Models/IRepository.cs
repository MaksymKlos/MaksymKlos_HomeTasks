using System.Collections.Generic;
using Models.Models;

namespace Models
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity Create(TEntity entity);

        void Update(TEntity entity);

        void Remove(int id);
        void Remove(TEntity entity);
    }
}