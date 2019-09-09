using System;
using System.Linq;
using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly TodoContext _context;

        public Repository(TodoContext context)
        {
            _context = context;
        }

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void Delete(long id)
        {
            var item = _context.Set<TEntity>().FirstOrDefault(e => e.Id == id);
            if (item != null)
            {
                _context.Set<TEntity>().Remove(item);
            }
        }

        public void Update(TEntity entity)
        {
            var item = _context.Set<TEntity>().FirstOrDefault(e => e.Id == entity.Id);
            item = entity;
        }

        public TEntity GetById(long id)
        {
            return _context.Set<TEntity>().FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<TEntity> Filter()
        {
            return _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public void SaveChanges() => _context.SaveChanges();
    }
}