using FEWA.Data.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace FEWA.Data.EntityFramework;

public class Repository<TEntity>(ApplicationDbContext dbContext) : IRepository<TEntity>
    where TEntity : Entity
{

    public async Task<TEntity?> GetByIdAsync(Guid id)
    {
        return await dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
    }

    public IEnumerable<TEntity> GetByAsync(Func<TEntity, bool> predicate)
    {
        var query = dbContext.Set<TEntity>().AsNoTracking();
        if (predicate != null)
        {
            query = query.Where(predicate);
        }
        
        return query;
    }

    public Task<TEntity> AddAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}