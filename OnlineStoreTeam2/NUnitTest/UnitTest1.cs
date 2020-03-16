using CurrencyService.Controllers;
using CurrencyService.models;
using PaymentService.Controllers;
using PaymentService.models;

using NUnit.Framework;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;

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
            double expected = 23.7835;
            var amount = 1;
            var convert = expected * amount;
            Assert.AreEqual(result, convert);
        }

        [Test]
        public void GetTransactionID_TargetNumber_Test()
        {
            var controller = new paymentserviceController();
            var currencychange = new PaymentModel();
            {
                currencychange.TargetNumber = "Test";
                currencychange.TotalToPay = 1;

            };

            string transactionID = "Test" + DateTime.Today.ToString("ddMMyyyy") + DateTime.Now.ToString("HHmmss");

            string result = controller.TransactionID(currencychange);
            var convert = transactionID;
            Assert.AreEqual(result, convert);
        }

    }
}