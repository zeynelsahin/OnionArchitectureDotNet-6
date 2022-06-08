using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Entity1> Type { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Entity1>().HasData(new Entity1() { Id = Guid.NewGuid(), Name = "Zeynel", Quantity = 1, Value = 1, CreateDate = DateTime.Now },
            new Entity1() { Id = Guid.NewGuid(), Name = "Zeynel", Quantity = 1, Value = 1, CreateDate = DateTime.Now },
            new Entity1() { Id = Guid.NewGuid(), Name = "Zeynel", Quantity = 1, Value = 1, CreateDate = DateTime.Now },
            new Entity1() { Id = Guid.NewGuid(), Name = "Zeynel", Quantity = 1, Value = 1, CreateDate = DateTime.Now });
        base.OnModelCreating(modelBuilder);
    }
}