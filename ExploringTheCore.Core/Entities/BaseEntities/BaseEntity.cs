using ExploringTheCore.Core.Contracts.Entities;
using System;

namespace ExploringTheCore.Core.Entities.BaseEntities
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateLastUpdated { get; set; }
    }
}
