using AutoMapper;
using Hotel_Layer.Entities.Concrete;
using HotelProjectUI.Dtos.ServiceDto;

namespace HotelProjectUI.AutoMapper
{
    public class MapConfig:Profile
    {
        public MapConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
        }
    }
}
