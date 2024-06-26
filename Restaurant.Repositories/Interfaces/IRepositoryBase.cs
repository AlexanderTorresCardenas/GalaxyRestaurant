﻿using Restaurant.Entities;
using System.Linq.Expressions;

namespace Restaurant.Repositories.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : EntityBase
{
    Task<ICollection<TEntity>> ListAsync();

    Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate);

    Task<TEntity?> FindAsync(int id);

    Task AddAsync(TEntity entity);

    Task UpdateAsync();

    Task DeleteAsync(int id);
}
