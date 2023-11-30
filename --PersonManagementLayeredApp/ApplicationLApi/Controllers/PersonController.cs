using BusinessLogicL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogicL.DTOs;

namespace ApplicationLApi.Controllers
{
    public class PersonController : ApiController
    {
        [HttpGet]
        [Route("api/getall")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = PersonService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
