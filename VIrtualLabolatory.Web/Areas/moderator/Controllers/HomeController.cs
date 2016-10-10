using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIrtualLabolatory.Web.Areas.moderator.Controllers
{

    [Authorize(Roles = "Administator, moderator")]
    public class HomeController : Controller
    {
        //
        // GET: /moderator/Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
