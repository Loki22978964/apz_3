using BLL.DTOs;
using System;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IContentService : IDisposable
    {
        IEnumerable<ContentDTO> GetAll();
        IEnumerable<ContentDTO> Search(string query, ISearchStrategy strategy);
        ContentDTO GetById(Guid id);
        void AddContent(ContentDTO dto);
        void DeleteContent(Guid id);

        IEnumerable<ContentTypeDTO> GetContentTypes();
        void AddContentType(ContentTypeDTO dto);

        IEnumerable<StorageDTO> GetStorageLocations();
        void AddStorageLocation(StorageDTO dto);
    }
}