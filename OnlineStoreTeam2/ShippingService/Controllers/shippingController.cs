using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShippingService.Models;

namespace ShippingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class shippingController : ControllerBase
    {
        //TODO
        [HttpPost]
        public double GetShippingServices(Cart cart, double total)
        {                                           
                var convert = total * 1.10;

                return convert;

            
        }
    }
}
