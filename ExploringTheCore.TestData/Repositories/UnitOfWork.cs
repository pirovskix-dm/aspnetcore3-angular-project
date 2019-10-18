using ExploringTheCore.Core.Contracts.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace ExploringTheCore.TestData.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task SaveAsync(CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }
    }
}
