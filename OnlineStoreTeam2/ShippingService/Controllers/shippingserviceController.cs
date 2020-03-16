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
    public class shippingserviceController : ControllerBase
    {
        //TODO
        [HttpPost]
        public async Task<double> GetShippingServices(Cart shipping, double total)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://");

                var response = await client.GetAsync($"");

                var stringResult = await response.Content.ReadAsStringAsync();

                var dictResult = JsonConvert.DeserializeObject<dynamic>(stringResult);            

                var convert = total * 1.10;

                return convert;

            }
        }
    }
}
