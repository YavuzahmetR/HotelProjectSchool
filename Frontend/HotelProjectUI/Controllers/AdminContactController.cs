using HotelProjectUI.Dtos.ContactDto;
using HotelProjectUI.Dtos.SendMessageDto;
using HotelProjectUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProjectUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/Contact");

            var client2 = _httpClientFactory.CreateClient();
            var response2 = await client2.GetAsync("https://localhost:7120/api/Contact/GetContactNumber");

            var client3 = _httpClientFactory.CreateClient();
            var response3 = await client3.GetAsync("https://localhost:7120/api/SendMessage/GetSendMessageNumber");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<List<InboxContactDto>>(dataJs);

                var dataJs2 = await response2.Content.ReadAsStringAsync();

                var dataJs3 = await response3.Content.ReadAsStringAsync();

                ViewBag.ContactNumber = dataJs2;

                ViewBag.SendMessageNumber = dataJs3;

                return View(modelObject);
            }
            return View();
        }
        public async Task<IActionResult> Sendbox()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/SendMessage");          
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<List<ResultSendboxDto>>(dataJs);               
                return View(modelObject);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessage createSendMessage)
        {
            createSendMessage.SenderMail = "admin@gmail.com";
            createSendMessage.SenderName = "admin";
            createSendMessage.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(createSendMessage);
            StringContent content = new StringContent(dataJs, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7120/api/SendMessage", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("SendBox");
            }
            return View();
        }
        public PartialViewResult SideBarAdminContactPartial()
        {
            return PartialView();
        }
        public PartialViewResult SideBarAdminContactCategoryPartial()
        {
            return PartialView();
        }
        public async Task<IActionResult> MessageDetailsBySendbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7120/api/SendMessage/{id}");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<GetMessageByIDDto>(dataJs);
                return View(modelObject);

            }
            return View();
        }

        public async Task<IActionResult> MessageDetailsByInbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7120/api/Contact/{id}");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<InboxContactDto>(dataJs);
                return View(modelObject);

            }
            return View();
        }
    }
}
