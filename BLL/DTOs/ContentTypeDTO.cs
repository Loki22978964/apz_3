using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ContentTypeDTO
    {
        public Guid Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string Format { get; set; } = string.Empty;
    }
}
