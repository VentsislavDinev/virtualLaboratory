using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIrtualLabolatory.Web.Areas.moderator.Controllers
{
    [Authorize(Roles="Administator, moderator")]
    public class LectureController : Controller
    {
        //
        // GET: /moderator/Lecture/

        public ActionResult Index()
        {
            return View();
        }

    }
}
