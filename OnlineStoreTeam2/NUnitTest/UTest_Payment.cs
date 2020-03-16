using PaymentService.Controllers;
using PaymentService.models;

using NUnit.Framework;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Currency_Test
{
    class UTest_Payment
    {
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
