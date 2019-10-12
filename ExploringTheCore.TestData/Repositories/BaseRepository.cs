using ExploringTheCore.Core.Contracts.Repositories;
using ExploringTheCore.Core.Entities.BaseEntities;
using ExploringTheCore.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace ExploringTheCore.TestData.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly List<TEntity> testData;

        public BaseRepository()
        {
            testData = new List<TEntity>();
        }

        public Task<IReadOnlyCollection<TEntity>> GetAllAsync(CancellationToken ct)
        {
            return Task.FromResult((IReadOnlyCollection<TEntity>)testData);
        }

        public Task<IReadOnlyCollection<T>> GetAllAsync<T>(Expression<Func<TEntity, T>> exp, CancellationToken ct)
        {
            var result = testData
                .Select(exp.Compile())
                .ToArray();

            return Task.FromResult((IReadOnlyCollection<T>)result);
        }

        public Task<TEntity?> GetAsync(Guid id, CancellationToken ct)
        {
            TEntity? result = testData.FirstOrNull(e => e.Id == id);
            return Task.FromResult(result);
        }

        public Task<T?> GetAsync<T>(Guid id, Expression<Func<TEntity, T>> exp, CancellationToken ct)
            where T : class
        {
            var func = exp.Compile();
            TEntity? entity = testData.FirstOrNull(e => e.Id == id);
            if (entity == null)
            {
                return Task.FromResult<T?>(null);
            }

            T result = func(entity);
            return Task.FromResult<T?>(result);
        }

        public void Add(TEntity entity)
        {
            entity.Id = Guid.NewGuid();
            testData.Add(entity);
        }

        public void Update(TEntity entity)
        {
            TEntity? result = testData.FirstOrNull(e => e.Id == entity.Id);
            if (result != null)
            {
                testData.Remove(result);
                testData.Add(entity);
            }
        }

        public void Remove(TEntity entity)
        {
            TEntity? result = testData.FirstOrNull(e => e.Id == entity.Id);
            if (result != null)
            {
                testData.Remove(result);
            }
        }
    }
}
