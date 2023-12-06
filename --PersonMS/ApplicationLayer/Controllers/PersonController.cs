using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationLayer.Controllers
{
    public class PersonController : ApiController
    {
        [HttpGet]
        [Route("api/getAllPerson")]

        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = PersonService.GetAll();

                return Request.CreateResponse(HttpStatusCode.OK,data);

            }catch (Exception ex){
                return Request.CreateResponse(HttpStatusCode.NotFound,ex);
            }
        }


        [HttpPost]
        [Route("api/Create")]

        public HttpResponseMessage Create(PersonDTO ps)
        {
            try
            {
                var data = PersonService.Create(ps);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
