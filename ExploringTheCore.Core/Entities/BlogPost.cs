using ExploringTheCore.Core.Contracts.Entities;
using ExploringTheCore.Core.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExploringTheCore.Core.Entities
{
    [Table("BlogPosts")]
    public class BlogPost : BaseEntity, IEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;
    }
}
