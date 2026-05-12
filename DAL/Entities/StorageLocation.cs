using DAL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class StorageLocation
    {
        public Guid Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string Url { get; set; } = string.Empty;
    }
}
 