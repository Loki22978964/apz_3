using DAL.Entities.Enum;

namespace DAL.Entities
{
    public class ContentType
    {
        public Guid Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public DataFormat Format { get; set; }
    }
}
