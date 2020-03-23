using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShippingService.models;

namespace ShippingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class shippingController : ControllerBase
    {
        //TODO
        //[Route("estimate")]
        [HttpPost("estimate/{total}")]
        public dynamic ShippingCostServices(double total)
        { 
            var ShippingCost = total * .20;

            var myjson = new
            {
                calculatedShippingCost = ShippingCost
            };

            var json = JsonConvert.SerializeObject(myjson);           
            JObject json2 = JObject.Parse(json);

            return json2;         
        }

        [Route("tracking")]
        [HttpPost]
        public dynamic TrackingID(Shipping shipping)
        {
            string trackingid = shipping.ZipCode + DateTime.Today.ToString("ddMMyyyy") + DateTime.Now.ToString("HHmmss");

            var myjsondata = new
            {
                trackingID = trackingid
            };

            string json = JsonConvert.SerializeObject(myjsondata);
            JObject json2 = JObject.Parse(json);

            return json2;
        }
    }
}
