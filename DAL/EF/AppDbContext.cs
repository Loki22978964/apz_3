using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class AppDbContext : DbContext
    {
        public DbSet<ContentItem> ContentItems { get; set; } = null!;
        public DbSet<ContentType> ContentTypes { get; set; } = null!;
        public DbSet<StorageLocation> StorageLocations { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Тут можна налаштувати Fluent API, якщо потрібно
            base.OnModelCreating(modelBuilder);
        }
    }
}
