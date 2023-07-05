using Microsoft.EntityFrameworkCore;

namespace Cobit_19.Data
{
    public class AppProvider<T, TKey> where T : AppModel<TKey> where TKey : IEquatable<TKey>
    {
        protected readonly AppDbContext _dbContext;

        protected AppProvider(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected async Task AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        protected Task DeleteAsync(TKey id)
        {
            var query = _dbContext.Set<T>()
              .Where(m => id.Equals(m.ID));
            return DeleteInternalAsync(query);
        }

        protected Task DeleteAsync(IEnumerable<TKey>? ids)
        {
            if (ids != null && ids.Any())
            {
                var query = _dbContext.Set<T>()
                  .Where(m => ids.Contains(m.ID));
                return DeleteInternalAsync(query);
            }
            return Task.CompletedTask;
        }

        protected static async Task DeleteInternalAsync(IQueryable<T> query)
        {
            await query.ExecuteDeleteAsync();
        }
    }
}
