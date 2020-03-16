using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingService.Models
{
    public class Cart
    {
        public int UserId { get; set; }
        public List<Items> Productos { get; set; }
    }
}
