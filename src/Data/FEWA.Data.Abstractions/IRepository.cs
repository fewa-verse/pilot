namespace FEWA.Data.Abstractions;

public interface IRepository
{
}

public interface IRepository<T> : IRepository
{
    Task<T?> GetByIdAsync(Guid id);
    IEnumerable<T> GetByAsync(Func<T, bool>? predicate);
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}