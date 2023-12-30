using HotelProjectUI.Dtos.BookingDto;
using HotelProjectUI.Dtos.ContactDto;
using HotelProjectUI.Dtos.MessageCategoryDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/MessageCategory");

            var dataJs = await response.Content.ReadAsStringAsync();
            var modelObject = JsonConvert.DeserializeObject<List<ResultMessageCategoryDto>>(dataJs);

            List<SelectListItem> categoriesOfMessages = (from item in modelObject
                                                         select new SelectListItem
                                                         {
                                                             Text = item.MessageCategoryName,
                                                             Value = item.MessageCategoryID.ToString()
                                                         }).ToList();
            ViewBag.v = categoriesOfMessages;

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
