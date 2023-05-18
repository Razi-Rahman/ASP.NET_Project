using BLL.DTOs.TravellerDTOs;
using BLL.Services.TravellerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalTravelAgency.Controllers
{
    public class PaymentController : ApiController
    {
        [HttpGet]
        [Route("api/payments")]
        public HttpResponseMessage Payment()
        {
            try
            {
                var data = PaymentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new
                {message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/payments/add")]
        public HttpResponseMessage AddPayment(PaymentDTO pay)
        {
            try
            {
                var data = PaymentService.Insert(pay);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new
                { message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/payments/update")]
        public HttpResponseMessage UpdatePayment (PaymentDTO pay)
        {
            try
            {
                var data = PaymentService.Update(pay);
                return Request.CreateResponse(HttpStatusCode.OK,data);
            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new
                { message = ex.Message });
            }
        }
    }
}
