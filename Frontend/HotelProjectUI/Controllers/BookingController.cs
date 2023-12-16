using HotelProjectUI.Dtos.BookingDto;
using HotelProjectUI.Dtos.Subscriber;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProjectUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task <IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
            createBookingDto.Status = "Onay Bekliyor";
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(createBookingDto);
            StringContent content = new StringContent(dataJs, Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:7120/api/Booking", content);
            return RedirectToAction("Index", "Default");
        }
    }
}
