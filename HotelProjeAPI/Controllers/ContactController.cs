using Hotel_Layer.Business.Abstract;
using Hotel_Layer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;   
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact) 
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
             _contactService.TInsert(contact);
            return Ok();
        }
        [HttpGet]
        public IActionResult InboxListContact()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }
        [HttpGet("GetContactNumber")]
        public IActionResult GetContactNumber()
        {
            return Ok(_contactService.TGetContactNumber());
        }
    }
}
