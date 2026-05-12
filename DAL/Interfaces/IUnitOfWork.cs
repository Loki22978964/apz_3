namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Entities.ContentItem> Content { get; }
        IRepository<Entities.StorageLocation> Storages { get; }
        IRepository<Entities.ContentType> ContentTypes { get; }

        void Save();
    }
}