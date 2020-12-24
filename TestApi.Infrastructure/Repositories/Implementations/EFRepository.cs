using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Core.Domain;
using TestApi.Infrastructure.Data;
using TestApi.Core.Interfaces;

namespace TestApi.Infrastructure.Repositories.Implementations
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly TodoDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        public EFRepository(TodoDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
