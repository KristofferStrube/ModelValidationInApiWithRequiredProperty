using Microsoft.AspNetCore.Mvc;

namespace ControllerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    [HttpPost(Name = "Make Order")]
    public IActionResult Post(Order order)
    {
        Console.WriteLine(order.OrderNumber.ToUpper());

        return Ok("Order made");
    }
}
