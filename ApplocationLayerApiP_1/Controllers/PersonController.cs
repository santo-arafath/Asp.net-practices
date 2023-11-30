﻿using BusinessLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplocationLayerApiP_1.Controllers
{
    public class PersonController : ApiController
    {

        [HttpGet]
        [Route("api/name/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = PersonService.GetName(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound,ex);

            }
        }
    }
}
