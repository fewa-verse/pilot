using Microsoft.EntityFrameworkCore;

namespace FEWA.Data.EntityFramework;

public abstract class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        base.OnModelCreating(modelBuilder);
    }
}