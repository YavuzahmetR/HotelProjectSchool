using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageFileController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> ImageUpload([FromForm]IFormFile file)
        {
            //wwwroot içine görsel dosyası göndermek için. Unique isim.
            var fileName = Guid.NewGuid()+Path.GetExtension(file.FileName);
            var directory = Path.Combine(Directory.GetCurrentDirectory(),"images/" + fileName);
            FileStream fileStream = new FileStream(directory,FileMode.Create);
            await file.CopyToAsync(fileStream);
            return Created("", file);

        }

    }
}
