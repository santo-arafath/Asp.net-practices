using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using Apipr2.EF;
using Apipr2.Models;




namespace Apipr2.Controllers
{
    public class DemoController : ApiController
    {

        [HttpGet]
        [Route("api/names")]
        public HttpResponseMessage Get()
        {
            var names = new string[] { "santo", "Arafath " };
            return Request.CreateResponse(HttpStatusCode.OK, names);
        }

        [HttpGet]
        [Route("api/state/{id}")]

        public HttpResponseMessage Getid(int id)
        {

            var name = id == 1 ? "santo" : "Not found";
            return Request.CreateResponse(HttpStatusCode.OK,name);
        }



        [HttpPost]
        [Route("api/create")]
        public HttpResponseMessage create(Student s)
        {
            var db = new StudentEntities();
            try
            {
                db.Students.Add(s);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Created");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }




        [HttpGet]
        [Route("api/all")]

        public HttpResponseMessage GetAll()
        {
            var db=new StudentEntities();

            try
            {
                var data = db.Students.ToList();


                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);
            }
        }



        [HttpGet]
        [Route("api/get/{id}")]

        public HttpResponseMessage GetByid(int id)
        {

            var db = new StudentEntities();

            try
            {

                var user = db.Students.Find(id);
                if(user == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "user not found" });

                }
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex);
            }
        }


        [HttpPut]
        [Route("api/update/{id}")]

         public HttpResponseMessage updateUser(Student s,int id)
        {
            var db = new StudentEntities();
            try
            {
                var user = db.Students.Find(id);
                if(user == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "user not found" });

                }
                //db.Entry(user).CurrentValues.SetValues(s);

                user.name = s.name;
                user.department = s.department;
                user.cgpa = s.cgpa;
                db.SaveChanges();

                return  Request.CreateResponse(HttpStatusCode.OK, s);

            }catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound,ex);
            }
        }



    }
}
