using CurrencyService.Controllers;
using CurrencyService.models;

using NUnit.Framework;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using CurrencyService.Models;
using Newtonsoft.Json;

namespace Tests
{
    public class UTest_Currency
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetExchangeRate_IngresaValores_RegresaConversion()
        {
            var controller = new currencyController();
            var currencychange = new CurrencyChange()
            {
                CurrencyCode = "EUR",
                CurrencyType = "MXN",
                Units = 1
            };

            double result = await controller.GetExchangeRate(currencychange);
            double expected = 23.7835;
            var amount = 1;
            var convert = expected * amount;
            Assert.AreEqual(result, convert);
        }


        [Test]
        public void GetExion()
        {
            var controller = new currencyController();

            var result = controller.GetRecomendation();
            var expected = new Class.Rates();
            result.ad(expected.MXN);
            var amount = 1;
            var convert = expected.MXN * amount;
            Assert.AreEqual(result, convert);
        }
    }
}