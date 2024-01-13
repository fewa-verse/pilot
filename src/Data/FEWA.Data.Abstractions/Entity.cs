namespace FEWA.Data.Abstractions;

public abstract class Entity<TId> : IEntity<TId>
{
    public required TId Id { get; set; }
}

public abstract class Entity : Entity<Guid>
{
    
}

public abstract class ClassicEntity : Entity<int>
{
}