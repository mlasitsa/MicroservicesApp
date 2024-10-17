using Microsoft.AspNetCore.Mvc;
using OrdersService.Models;
using System.Collections.Generic;

namespace OrdersService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private static readonly List<Order> Orders = new();

        [HttpGet]
        public IActionResult Get() => Ok(Orders);

        [HttpPost]
        public IActionResult Create(Order order)
        {
            order.Id = Orders.Count + 1;
            order.OrderDate = DateTime.Now;
            Orders.Add(order);
            return CreatedAtAction(nameof(Get), new { id = order.Id }, order);
        }
    }
}
