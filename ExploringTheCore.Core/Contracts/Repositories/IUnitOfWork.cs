using System.Threading;
using System.Threading.Tasks;

namespace ExploringTheCore.Core.Contracts.Repositories
{
    public interface IUnitOfWork
    {
        Task SaveAsync(CancellationToken cancellationToken = default);
    }
}
