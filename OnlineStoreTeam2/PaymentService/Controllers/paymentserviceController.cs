using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentService.models;

namespace PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class paymentserviceController : ControllerBase
    {
        // POST: api/paymentservice
        [HttpPost]
        public string TransactionID(PaymentModel payment)
        {
            string transactionID = payment.TargetNumber + DateTime.Today.ToString("ddMMyyyy") + DateTime.Now.ToString("HHmmss");
            return transactionID;
        }




    }   
}               