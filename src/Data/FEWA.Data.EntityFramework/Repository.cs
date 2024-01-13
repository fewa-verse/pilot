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

    public IEnumerable<TEntity> GetByAsync(Func<TEntity, bool>? predicate = null)
    {
        var query = dbContext.Set<TEntity>().AsNoTracking();
        return predicate != null ? query.Where(predicate) : query;
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