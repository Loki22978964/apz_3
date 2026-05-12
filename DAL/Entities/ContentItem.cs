using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ContentItem
    {
        public Guid Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string Description { get; set; } = string.Empty;
        public TimeSpan Time { get; set; }

        public Guid ContentTypeId { get; set; }
        public virtual ContentType ContentType { get; set; } = null!;

        public Guid StorageLocationId { get; set; }
        public virtual StorageLocation StorageLocation { get; set; } = null!;
    }
}
