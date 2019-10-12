using ExploringTheCore.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace ExploringTheCore.Core.Contracts.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity
    {
        Task<IReadOnlyCollection<TEntity>> GetAllAsync(CancellationToken ct);
        Task<IReadOnlyCollection<T>> GetAllAsync<T>(Expression<Func<TEntity, T>> exp, CancellationToken ct);
        Task<TEntity?> GetAsync(Guid id, CancellationToken ct);
        Task<T?> GetAsync<T>(Guid id, Expression<Func<TEntity, T>> exp, CancellationToken ct) where T : class;
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
