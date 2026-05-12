using AutoMapper;
using DAL.Entities;
using BLL.DTOs;

namespace BLL.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // DAL -> DTO
            CreateMap<ContentItem, ContentDTO>()
                .ForMember(dest => dest.ContentTypeName, opt => opt.MapFrom(src => src.ContentType.Name))
                .ForMember(dest => dest.StorageUrl, opt => opt.MapFrom(src => src.StorageLocation.Url));

            // Використовуй ту назву класу, яка у тебе у файлі (ContentTypedDTO або ContentTypeDTO)
            CreateMap<ContentType, ContentTypeDTO>();
            CreateMap<StorageLocation, StorageDTO>();

            // DTO -> DAL (для створення)
            CreateMap<ContentDTO, ContentItem>();
            CreateMap<ContentTypeDTO, ContentType>();
            CreateMap<StorageDTO, StorageLocation>();
        }
    }
}