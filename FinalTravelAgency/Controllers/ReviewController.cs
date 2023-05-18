using BLL.DTOs.AdminDTOs;
using BLL.Services.TravellerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace FinalTravelAgency.Controllers
{
    public class ReviewController : ApiController
    {
        [HttpGet]
        [Route("api/reviews")]
        public HttpResponseMessage Review()
        {
            try
            {
                var data = ReviewService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/reviews/add")]
        public HttpResponseMessage InsertReviews(ReviewDTO tra)
        {
            try
            {
                var data = ReviewService.Insert(tra);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
          catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/reviews/update")]
        public HttpResponseMessage Update (ReviewDTO tra)
        {
            try
            {
                var data = ReviewService.Update(tra);
                return Request.CreateResponse (HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/reviews/delete/{id}")]
        public HttpResponseMessage ReviewDelete(string id)
        {
            var res = ReviewService.DeleteReview(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }
    }
}
