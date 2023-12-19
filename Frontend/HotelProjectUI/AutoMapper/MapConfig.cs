using AutoMapper;
using Hotel_Layer.Entities.Concrete;
using HotelProjectUI.Dtos.AboutDto;
using HotelProjectUI.Dtos.AppUserDto;
using HotelProjectUI.Dtos.BookingDto;
using HotelProjectUI.Dtos.ContactDto;
using HotelProjectUI.Dtos.LoginDto;
using HotelProjectUI.Dtos.RoomDto;
using HotelProjectUI.Dtos.ServiceDto;
using HotelProjectUI.Dtos.StaffDto;
using HotelProjectUI.Dtos.Subscriber;
using HotelProjectUI.Dtos.TestimonialDto;

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
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<ResultStaffDto, Staff>().ReverseMap();
            CreateMap<CreateSubscriberDto, Subscriber>().ReverseMap();
            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();
            CreateMap<CreateContactDto,Contact>().ReverseMap();
            CreateMap<ResultRoomDto, Room>().ReverseMap();
            CreateMap<CreateRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();

        }
    }
}
