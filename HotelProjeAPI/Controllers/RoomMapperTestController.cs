using AutoMapper;
using Hotel_Layer.Business.Abstract;
using Hotel_Layer.DTO.Dtos.Room;
using Hotel_Layer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomMapperTestController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public RoomMapperTestController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(AddRoomDto dtoObject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var mapper = _mapper.Map<Room>(dtoObject);
            _roomService.TInsert(mapper);
            return Ok("Başarıyla Eklendi !");
        }
        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto dtoObject)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var mapper = _mapper.Map<Room>(dtoObject);
            _roomService.TUpdate(mapper);
            return Ok("Başarıyla Güncellendi !");
        }
    }
}
