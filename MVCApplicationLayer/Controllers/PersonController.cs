using BusinessLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplicationLayer.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            var id = Convert.ToInt32(fc["Id"]);
            ViewBag.name = PersonService.GetName(id);
            return View();
        }
    }
}