using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationLayer.Controllers
{
    public class CategoryController : ApiController
    {
        [HttpGet]
        [Route("api/Category/{id}")]
        public HttpResponseMessage GetCatById(int id)
        {
            try
            {
                var data = "hellosadman";

                return Request.CreateResponse(HttpStatusCode.OK,data);
            }catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }
    }
}
