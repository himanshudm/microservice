using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.OrderService.Entities
{
    public class Orders
    {
        public int OrderId { get; set; }
        public decimal OrderAmount { get; set; }
        public string OrderDate { get; set; }
    }
}
