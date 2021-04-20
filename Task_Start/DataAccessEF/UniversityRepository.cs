using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Models;

namespace DataAccessEF
{
    public class UniversityRepository<TEntity>:IRepository<TEntity> where TEntity :class
    {
        private readonly UniversityContext _context;
        protected DbSet<TEntity> DbSet;


        public UniversityRepository(UniversityContext context)
        {
            _context = context;
            context.Database.EnsureCreated();
            DbSet = _context.Set<TEntity>();
        }

        public List<TEntity> GetAll() => _context.Set<TEntity>().ToList();


        public TEntity GetById(int id) => DbSet.Find(id);

        public TEntity Create(TEntity entity)
        {
            var result = DbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
            _context.SaveChanges();
        }
        public void Remove(int id)
        {
            var entity = GetById(id);
            DbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}
