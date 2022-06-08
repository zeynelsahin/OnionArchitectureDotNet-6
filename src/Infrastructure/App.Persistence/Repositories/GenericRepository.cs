using Add.Application.Interfaces.Repository;
using App.Domain.Common;
using App.Domain.Entities;
using App.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.Repositories;

public class GenericRepository<T>: IGenericRepository<T> where T : BaseEntitiy
{
    private ApplicationDbContext _dbContext;

    public GenericRepository( ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Entity1>> GetAllAsync()
    {
        var entity1s = await _dbContext.Set<Entity1>().ToListAsync();
        return entity1s;
    }

    public Task<T> GetByIdAsync(Guid id)
    {
        return null;
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }
}