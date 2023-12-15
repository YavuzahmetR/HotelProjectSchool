using AutoMapper;
using Hotel_Layer.Entities.Concrete;
using HotelProjectUI.Dtos.AppUserDto;
using HotelProjectUI.Dtos.LoginDto;
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
            CreateMap<CreateUserDto, AppUser>().ReverseMap();
            CreateMap<SignInUserDto,AppUser>().ReverseMap();
        }
    }
}
