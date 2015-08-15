using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Web;
using System.Web.Mvc;
using WebProto.Models;
using WebProto.ServiceReference1;

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
        public RedirectToRouteResult Index(Account log)
        {
            Service1Client service = new Service1Client();
            string[] user= service.ValidateLogin(log.Email, log.Password);

            if (user != null)
            {
                log.PrimerApellido = user[2].ToString();
                log.PrimerNombre = user[3].ToString();
                log.SegundoApellido = user[4].ToString();
                log.SegundoNombre = user[5].ToString();
                log.Activo = user[6];
                log.FechaCreacion = user[7];
                log.FechaIngreso = user[8];
                log.TalentoHumano = user[9];

                Session["User"] = log;
                return RedirectToAction("Dashboard", "AccountPage");
            }

            Session["User"] = null;

            service.Close();
            return RedirectToAction("Index");
        }
    }
}