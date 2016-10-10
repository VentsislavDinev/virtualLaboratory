using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIrtualLabolatory.Web.Areas.moderator.Controllers
{

    [Authorize(Roles = "Administator, moderator")]
    public class ContactController : Controller
    {
        //
        // GET: /moderator/Contact/

        public ActionResult Index()
        {
            return View();
        }

    }
}
