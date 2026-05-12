using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using System;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IRepository<ContentItem>? _contentRepository;
        private IRepository<StorageLocation>? _storageRepository;
        private IRepository<ContentType>? _contentTypeRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IRepository<ContentItem> Content =>
            _contentRepository ??= new GenericRepository<ContentItem>(_context);

        public IRepository<StorageLocation> Storages =>
            _storageRepository ??= new GenericRepository<StorageLocation>(_context);

        public IRepository<ContentType> ContentTypes =>
            _contentTypeRepository ??= new GenericRepository<ContentType>(_context);

        public void Save() => _context.SaveChanges();

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}