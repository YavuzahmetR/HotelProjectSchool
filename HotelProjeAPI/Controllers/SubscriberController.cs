using Hotel_Layer.Business.Abstract;
using Hotel_Layer.DataAccess.Abstract;
using Hotel_Layer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberController : ControllerBase
    {
        private readonly ISubscriberService _subscriberService;
        public SubscriberController(ISubscriberService subscriberService)
        {
            _subscriberService = subscriberService;
        }
        [HttpGet]
        public IActionResult SubscriberList()
        {
            var values = _subscriberService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscriber(int id) 
        {
            var value = _subscriberService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete]
        public IActionResult DeleteSubscriber(int id) 
        {
            var value = _subscriberService.TGetById(id);
            _subscriberService.TDelete(value);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddSubscriber(Subscriber subscriber) 
        {
            _subscriberService.TInsert(subscriber);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscriber(Subscriber subscriber)
        {
            _subscriberService.TUpdate(subscriber);
            return Ok();
        }

    }
}
