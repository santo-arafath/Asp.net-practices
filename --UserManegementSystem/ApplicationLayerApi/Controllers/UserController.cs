using BusinessLL.DTOs;
using BusinessLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationLayerApi.Controllers
{
    public class UserController : ApiController
    {

        [HttpGet]
        [Route("api/all_User")]

        public HttpResponseMessage Get()
        {
            try
            {
                var data = UserService.getAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex){
                return Request.CreateResponse(HttpStatusCode.OK, ex);

            }
        }


        [HttpGet]
        [Route("api/UserById/{id}")]

        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = UserService.getUserById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);

            }
        }




        [HttpPost]
        [Route("api/Create")]

        public HttpResponseMessage Create(UserDTO udt)
        {
            try
            {
                var msg = UserService.CreateUser(udt);
                return Request.CreateResponse(HttpStatusCode.OK, msg);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);

            }
        }


        [HttpDelete]
        [Route("api/Delete/{id}")]

        public HttpResponseMessage DeleteUser(int id)
        {
            try
            {
                var msg = UserService.DeleteUser(id);
                return Request.CreateResponse(HttpStatusCode.OK, msg);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);

            }
        }

        [HttpPut]
        [Route("api/UpdateUser/{id}")]

        public HttpResponseMessage DeleteUser(UserDTO udt,int id)
        {
            try
            {
                var msg = UserService.UpdateUser(udt,id);
                return Request.CreateResponse(HttpStatusCode.OK, msg);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);

            }
        }


    }
}
