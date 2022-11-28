using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Services;

namespace src.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
         private readonly ILogger<OrderController> _logger;
         private OrderService _orderService;


         [HttpPost]
         public IActionResult CreateOrder(Order order){
           var ordersubmitted =  _orderService.CreateOrder(order);
            if(ordersubmitted == null){
                return BadRequest();
            }
            return Ok();
         }

    }
}