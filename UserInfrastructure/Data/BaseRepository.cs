using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UserCore.Models;

namespace UserInfrastructure.Data
{
    public interface IBaseRepository<T, TKey> where T : class
    {
        Task<T> FindAsync(TKey id);
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> where);
        IQueryable<T> Get(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes);
        Task AddAsync(T entity);
        Task AddRangce(IEnumerable<T> entities);
        void Update(T entity);
        Task<bool> Remove(TKey id);
    }

    public class BaseRepository<T, Tkey> : IBaseRepository<T, Tkey> where T : class
    {
        private UserManagementContext _UserManagementContext;
        private DbSet<T> dbSet;

        public BaseRepository(UserManagementContext UserManagementContext)
        {
            _UserManagementContext = UserManagementContext;
            dbSet = _UserManagementContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangce(IEnumerable<T> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public async Task<T> FindAsync(Tkey id)
        {
            return await dbSet.FindAsync(id);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes)
        {
            var result = dbSet.Where(where);
            foreach (var include in includes)
            {
                result = result.Include(include);
            }
            return result;
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where);
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public async Task<bool> Remove(Tkey id)
        {
            T entity = await dbSet.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            dbSet.Remove(entity);
            return true;
        }

        public void Update(T entity)
        {
            _UserManagementContext.Entry<T>(entity).State = EntityState.Modified;
        }
    }
}
