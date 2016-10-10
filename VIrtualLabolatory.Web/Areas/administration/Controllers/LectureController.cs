using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIrtualLabolatory.Web.Areas.administration.Controllers
{

    [Authorize(Roles = "Administator")]
    public class LectureController : Controller
    {
        //
        // GET: /administration/Lecture/

        public ActionResult Index()
        {
            return View();
        }

    }
}
