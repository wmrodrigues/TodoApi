using System;
using TodoApi.Models;
using System.Collections.Generic;

namespace TodoApi.Repositories
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Delete(long id);
        void Update(TEntity entity);

        TEntity GetById(long id);
        IEnumerable<TEntity> Filter();
        IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate);
        void SaveChanges();
    }
}