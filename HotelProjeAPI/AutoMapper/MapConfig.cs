using AutoMapper;
using Hotel_Layer.DTO.Dtos.Room;
using Hotel_Layer.Entities.Concrete;

namespace HotelProjeAPI.AutoMapper
{
    public class MapConfig:Profile
    {
        public MapConfig()
        {
            CreateMap<Room, AddRoomDto>().ReverseMap();
            CreateMap<Room, UpdateRoomDto>().ReverseMap();
        }
    }
}
