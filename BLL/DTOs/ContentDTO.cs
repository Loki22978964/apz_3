using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ContentDTO
    {
        public Guid Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string Description { get; set; } = string.Empty;
        public TimeSpan Duration { get; set; }

        public Guid ContentTypeId { get; set; }
        public Guid StorageLocationId { get; set; }

        public string ContentTypeName { get; set; } = string.Empty;
        public string DataFormat { get; set; } = string.Empty;
        public string StorageName { get; set; } = string.Empty;
        public string StorageUrl { get; set; } = string.Empty;
    }
}
