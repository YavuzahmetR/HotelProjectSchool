using Hotel_Layer.Business.Abstract;
using Hotel_Layer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }
        [HttpPut("BookingStatusChangeAPI")]
        public IActionResult BookingStatusChangeAPI(Booking booking)
        {
            _bookingService.TBookingStatusChangeApprovedAPI(booking);
            return Ok();
        }
        [HttpPut("BookingStatusChangeAdmin")]
        public IActionResult BookingStatusChangeAdmin(int id)
        {
            _bookingService.TBookingStatusChangeApprovedAdmin(id);
            return Ok();
        }
        [HttpPut("BookingStatusChangeCanceled")]
        public IActionResult BookingStatusChangeCanceled(int id)
        {
            _bookingService.TBookingStatusChangeCanceled(id);
            return Ok();
        }
        [HttpPut("BookingStatusChangeWaitLine")]
        public IActionResult BookingStatusChangeWaitLine(int id)
        {
            _bookingService.TBookingStatusChangeWaitLine(id);
            return Ok();
        }
        [HttpGet("Last6Booking")]
        public IActionResult Last6Booking()
        {
            var values = _bookingService.TLast6Bookings();
            return Ok(values);
        }
    }
}
