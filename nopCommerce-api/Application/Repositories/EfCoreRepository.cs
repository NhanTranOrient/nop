using Microsoft.EntityFrameworkCore;
using nopCommerce_api.Application.Repositories.IRepositories;
using nopCommerce_api.Domain.Entities;
using nopCommerce_api.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nopCommerce_api.Application.Repositories
{
    public abstract class EfCoreRepository<TEntity> : IRepository<TEntity>
       where TEntity : class, IEntity
    {
        protected readonly AppDbContext _context;

        public EfCoreRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
