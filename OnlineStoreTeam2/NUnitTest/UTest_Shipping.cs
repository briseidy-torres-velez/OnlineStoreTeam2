using NUnit.Framework;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using ShippingService.Controllers;
using ShippingService.Models;
using System.Collections.Generic;

namespace UnitTest_Team2
{
    class UTest_Shipping
    {
        [Test]
        public void GetShipping_Calculate()
        {
            var controller = new shippingController();
            var total = 11;
            Items oItems = new Items();                         

            Cart jsonObject = new Cart();
            {
                jsonObject.UserId = 1;
            };
            jsonObject.Productos = new List<Items>();
            jsonObject.Productos.Add(new Items()
                {
                ProductId = 1,
                Quantity = 1,
                });
                          
            double result = controller.GetShippingServices(jsonObject, total);
            var convert = total * 1.10;
            Assert.AreEqual(result, convert);
        }
    }
}
