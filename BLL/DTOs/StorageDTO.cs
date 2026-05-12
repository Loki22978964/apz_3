using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StorageDTO
    {
        public Guid Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string Url { get; set; } = string.Empty;
    }
}
