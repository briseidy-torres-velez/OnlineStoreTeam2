using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace ShippingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class shippingController : ControllerBase
    {
        //TODO
        [HttpPost]
        public double GetShippingServices( double total)
        {                                           
                var shippingCost = total * .15;

                return shippingCost;

            
        }
    }
}
