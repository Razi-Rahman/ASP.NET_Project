using BLL.DTOs.AdminDTOs;
using BLL.Services.AdminServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalTravelAgency.Controllers
{
    public class PackageController : ApiController
    {
        [HttpGet]
        [Route("api/packages")]
        public HttpResponseMessage Package()
        {
            try
            {
                var data = PackageService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/packages/add")]
        public HttpResponseMessage InsertPackage(PackageDTO tra)
        {
            try
            {
                var data = PackageService.Insert(tra);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/packages/update")]
        public HttpResponseMessage Update(PackageDTO tra)
        {
            try
            {
                var data = PackageService.Update(tra);
                return  Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/packages/delete/{id}")]
        public HttpResponseMessage PackageDelete(string id)
        {
            var res = PackageService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }
    }
}
