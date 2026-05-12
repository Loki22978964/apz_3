using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class ContentService : IContentService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;

        public ContentService(IUnitOfWork uow, IMapper mapper)
        {
            _db = uow;
            _mapper = mapper;
        }

        public IEnumerable<ContentDTO> GetAll()
        {
            var items = _db.Content.GetAll();
            return _mapper.Map<IEnumerable<ContentDTO>>(items);
        }

        public IEnumerable<ContentDTO> Search(string query, ISearchStrategy strategy)
        {
            if (string.IsNullOrWhiteSpace(query)) return GetAll();

            var expression = strategy.GetSearchExpression(query);
            var results = _db.Content.Find(expression);

            return _mapper.Map<IEnumerable<ContentDTO>>(results);
        }

        public ContentDTO GetById(Guid id)
        {
            var item = _db.Content.GetById(id);
            return item == null ? null : _mapper.Map<ContentDTO>(item);
        }

        public void AddContent(ContentDTO dto)
        {
            var entity = _mapper.Map<ContentItem>(dto);
            _db.Content.Create(entity);
            _db.Save();
        }   

        public void DeleteContent(Guid id)
        {
            _db.Content.Delete(id);
            _db.Save();
        }

        public IEnumerable<ContentTypeDTO> GetContentTypes()
        {
            var types = _db.ContentTypes.GetAll();
            return _mapper.Map<IEnumerable<ContentTypeDTO>>(types);
        }

        public void AddContentType(ContentTypeDTO dto)
        {
            var entity = _mapper.Map<ContentType>(dto);
            _db.ContentTypes.Create(entity);
            _db.Save();
        }

        public IEnumerable<StorageDTO> GetStorageLocations()
        {
            var storages = _db.Storages.GetAll();
            return _mapper.Map<IEnumerable<StorageDTO>>(storages);
        }
    
        public void AddStorageLocation(StorageDTO dto)
        {
            var entity = _mapper.Map<StorageLocation>(dto);
            _db.Storages.Create(entity);
            _db.Save();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}