using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Web;
using System.Web.Mvc;
using WebProto.Models;
using WebProto.ServiceReference1;
using WebService;

namespace WebProto.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            if (Session["User"] != null)
            {
                return RedirectToAction("Dashboard", "AccountPage");
            }

            return View();     
        }

        [HttpPost]
        public RedirectToRouteResult Index(User log)
        {
            Service1Client service = new Service1Client();
            Empleado emp = service.ValidateLogin(log.Email, log.Password);
            
            if (emp != null)
            {
                Session["User"] = emp;
                return RedirectToAction("Dashboard", "AccountPage");
            }

            Session["User"] = null;

            service.Close();
            return RedirectToAction("Index");
        }
    }
}