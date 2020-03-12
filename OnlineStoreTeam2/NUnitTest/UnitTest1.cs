using CurrencyService.Controllers;
using CurrencyService.models;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetExchangeRate_IngresaValores_RegresaConversion()
        {
            var controller = new currencyserviceController();
            var currencychange = new CurrencyChange()
            {
                CurrencyCode = "EUR",
                CurrencyType = "MXN",
                Units = 1
            };

            double result = await controller.GetExchangeRate(currencychange);
            double expected = 24.8028;
            var amount = 1;
            var convert = expected * amount;
            Assert.AreEqual(result, convert);
        }
    }
}