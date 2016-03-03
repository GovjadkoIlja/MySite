using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;

namespace MvcApplication4.Controllers
{
    public class FilmsController : Controller
    {
        //
        // GET: /Films/

        public ActionResult Kino()
        {
            var mass = Filmmass.makemass();
            return View(mass);
        }

    }
}
