using System;

namespace ExploringTheCore.BLL.Models
{
    public abstract class BaseDTO
    {
        public Guid Id { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateLastUpdated { get; set; }
    }
}
