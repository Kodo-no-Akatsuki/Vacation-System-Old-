using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProto.Models;

namespace WebProto.Controllers
{
    public class AccountPageController : Controller
    {
        // GET: AccountPage
        public ViewResult Dashboard()
        {
            return View("Profile", Session["User"] as User);
        }

        public RedirectToRouteResult LogOut()
        {
            Session["User"] = null;

            return RedirectToAction("Index", "Home");
        }
    }
}