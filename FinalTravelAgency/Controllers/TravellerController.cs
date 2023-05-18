using BLL.DTOs.TravellerDTOs;
using BLL.Services.TravellerServices;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalTravelAgency.Controllers
{
    [EnableCors("*")]
    public class TravellerController : ApiController
    {
        [HttpGet]
        [Route("api/travellers")]
        public HttpResponseMessage Travellers()
        {
            try
            {
                var data = TravellerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });

            }
        }
        [HttpPost]
        [Route("api/travellers/add")]
        public HttpResponseMessage InsertTraveller(TravellerDTO tra)
        {
            try
            {
                var data = TravellerService.Insert(tra);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });

            }
        }
        [HttpPost]
        [Route("api/travellers/update")]
        public HttpResponseMessage Update(TravellerDTO tra)
        {
            try
            {
                var data = TravellerService.Update(tra);
                return Request.CreateResponse(HttpStatusCode.OK,data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/travellers/delete/{id}")]
        public HttpResponseMessage TravellerDelete (string id)
        {
            var res = TravellerService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK,res);
        }
     }
 }

