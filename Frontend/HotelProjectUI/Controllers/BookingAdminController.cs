using HotelProjectUI.Dtos.BookingDto;
using HotelProjectUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProjectUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/Booking");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<List<ResultBookingDto>>(dataJs);
                return View(modelObject);
            }
            return View();
        }
        public async Task<IActionResult> ApprovedReservationAPI(ApprovedReservationDto approvedReservationDto)
        {           
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(approvedReservationDto);
            StringContent content = new StringContent(dataJs, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"https://localhost:7120/api/Booking/BookingStatusChangeAPI", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> ApprovedReservationAdmin(ApprovedReservationDto approvedReservationDto,int id)
        {
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(approvedReservationDto);
            StringContent content = new StringContent(dataJs, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"https://localhost:7120/api/Booking/BookingStatusChangeAdmin?id="+id, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
