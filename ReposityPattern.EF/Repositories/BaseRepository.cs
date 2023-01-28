﻿using RepositoryPattern.Core.Repositories;

namespace RepositoryPattern.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext context;
        public BaseRepository(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
          var cretiria =  context.Set<T>().ToList();
            return (cretiria);
        }
        public async Task<T> GetById(int id) {
            var cretiria = await context.Set<T>().FindAsync(id);
            return (cretiria);
        }
        public async Task<T> Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }
        public async Task<T> Delete(T entity)
        {
            
            context.Set<T>().Remove(entity);
            context.SaveChanges();
            return entity;
        }

       

        public async Task<T> Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
