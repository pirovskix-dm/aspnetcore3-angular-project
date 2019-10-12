using System;

namespace ExploringTheCore.Core.Contracts.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime? DateCreated { get; set; }
        DateTime? DateLastUpdated { get; set; }
    }
}
