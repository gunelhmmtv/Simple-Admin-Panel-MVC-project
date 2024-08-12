using Microsoft.EntityFrameworkCore;
using ProjectDataAccessLayer.Abstract;
using ProjectDataAccessLayer.EntityFramework.Context;
using ProjectEntities.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccessLayer.Concrete.EfCoreRepositories.Commons
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly ProductContext _context;

        public  DbSet<T> TableEntity => _context.Set<T>();

        public GenericRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(T entity)
        {
            var addedState = await TableEntity.AddAsync(entity);
            return addedState.State == EntityState.Added;

        }
        public async Task<IEnumerable<T>> GetAllAsync(bool tracking = true)
        {
            if (tracking is false)
            {
                return await TableEntity.AsNoTracking().ToListAsync();

            }
            return await TableEntity.ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id) => await TableEntity.FindAsync(id);

        public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> expression)
            => await TableEntity.Where(expression).ToListAsync();

        public bool Remove(T entity)
        {
            var removed = TableEntity.Remove(entity);
            return removed.State == EntityState.Deleted;
        }

        public bool Update(T entity)
        {
            var updated = TableEntity.Update(entity);
            return updated.State == EntityState.Modified;
        }



        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        //public Task<IEnumerable<Product>> GetProducts()
        //{
        //    throw new NotImplementedException();
        //}


        //public Task<bool> AddAsync(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<T>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<T> GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> expression)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> Remove(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task SaveChangesAsync(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> Update(T entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
