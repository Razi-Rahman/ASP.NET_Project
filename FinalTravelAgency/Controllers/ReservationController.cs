using BLL.DTOs.AdminDTOs;
using BLL.Services.TravellerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalTravelAgency.Controllers
{
    public class ReservationController : ApiController
    {
        [HttpGet]
        [Route("api/reservation")]
        public HttpResponseMessage Reservation()
        {
            try
            {
                var data = ReservationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/reservations/add")]
        public HttpResponseMessage Insert(ReservationDTO tra)
        {
            try
            {
                var data = ReservationService.Insert(tra);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/reservations/update")]
        public HttpResponseMessage Update(ReservationDTO tra)
        {
            try
            {
                var data = ReservationService.Update(tra);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = ex.Message });
            }
        }
    }
}
