using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.OrderService.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET: api/Order
        [HttpGet]
        public IEnumerable<Orders> Get()
        {
            List<Orders> orders = new List<Orders>();
            orders.Add(new Orders { OrderId = 1, OrderAmount = 250, OrderDate = "12 Aug 2020" });
            orders.Add(new Orders { OrderId = 2, OrderAmount = 149, OrderDate = "14 Aug 2020" });
            return orders;
        }
    }
}
