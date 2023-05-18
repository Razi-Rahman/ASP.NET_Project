using BLL.DTOs.AdminDTOs;
using BLL.Services.AdminServices;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace FinalTravelAgency.Controllers
{
    [EnableCors("*")]
    public class AdminController : ApiController
    {
        [HttpGet]
        [Route("api/admins")]
        public HttpResponseMessage Admins()
        {
            try
            {
                var data = AdminService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/admins/add")]
        public HttpResponseMessage InsertAdmin(AdminDTO admin) 
        {
            try
            {
                var data = AdminService.Insert(admin);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/admins/update")]
        public HttpResponseMessage Update(AdminDTO adm)
        {
            try
            {
                var data = AdminService.Update(adm);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/admins/delete/{id}")]
        public HttpResponseMessage AdminDelete (int id)
        {
            var res = AdminService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }
    }
}
