using AutoMapper;
using VideoGameMetadataApi.CommunicationModel.Dtos;
using VideoGameMetadataApi.Model.Entities;

namespace VideoGameMetadataApi.Utilities
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<GameDto, Category>().ReverseMap();
            CreateMap<PublisherDto, Publisher>().ReverseMap();
        }
    }
}
