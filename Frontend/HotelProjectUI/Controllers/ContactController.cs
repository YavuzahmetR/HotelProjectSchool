using HotelProjectUI.Dtos.BookingDto;
using HotelProjectUI.Dtos.ContactDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProjectUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult MessageSend()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> MessageSend(CreateContactDto createContactDto)
        {
            createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(createContactDto);
            StringContent content = new StringContent(dataJs, Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:7120/api/Contact", content);
            return RedirectToAction("Index", "Default");
        }
    }
}
