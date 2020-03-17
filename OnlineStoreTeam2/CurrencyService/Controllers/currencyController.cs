using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CurrencyService.models;
using CurrencyService.Models;

namespace CurrencyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class currencyController : ControllerBase
    {
        // api/currencyservice/

        [Route("conversion")]
        [HttpPost]
        public async Task<double> GetExchangeRate(CurrencyChange currencyChange)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://api.exchangeratesapi.io/latest");
                var response = await client.GetAsync($"?base={currencyChange.CurrencyCode}&symbols={currencyChange.CurrencyType}&amount={currencyChange.Units}");

                var stringResult = await response.Content.ReadAsStringAsync();
                var dictResult = JsonConvert.DeserializeObject<dynamic>(stringResult);

                var exchangeValue = dictResult.rates[$"{currencyChange.CurrencyType}"];
                var convert = exchangeValue * currencyChange.Units;

                return convert;

            }
        }

        //[HttpGet]
        //[Route("")]
        //public ActionResult GetRecomendation()
        //{
        //    HttpClient recomendation = new HttpClient();
        //    recomendation.BaseAddress = new Uri("https://api.exchangeratesapi.io/latest");

        //    var response = recomendation.GetAsync("");
        //    response.Wait();
        //    var items = response.Result.Content.ReadAsStringAsync().Result;
        //    Class @class = new Class();
            
        //    var dictResult = JsonConvert.DeserializeObject<dynamic>(items);

        //    Class.Rates rates = new Class.Rates();
        //    rates.MXN = items.Where<double>(MX);

        //    return Ok(dictResult);
        //}

    }
}