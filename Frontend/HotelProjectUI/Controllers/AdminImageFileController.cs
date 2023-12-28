using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace HotelProjectUI.Controllers
{
    public class AdminImageFileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile imageFile)
        {
            var stream = new MemoryStream();
            await imageFile.CopyToAsync(stream);
            var bytes = stream.ToArray();

            ByteArrayContent byteArray = new ByteArrayContent(bytes);
            byteArray.Headers.ContentType = new MediaTypeHeaderValue(imageFile.ContentType);
            MultipartFormDataContent multipartFormData = new MultipartFormDataContent();
            multipartFormData.Add(byteArray, "file", imageFile.FileName);
            var httpClient = new HttpClient();
            await httpClient.PostAsync("https://localhost:7120/api/ImageFile", multipartFormData);
            return View();
        }

    }
}
