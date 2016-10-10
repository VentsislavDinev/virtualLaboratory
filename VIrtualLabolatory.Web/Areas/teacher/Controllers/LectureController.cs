using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIrtualLabolatory.Web.Areas.teacher.Controllers
{
    [Authorize(Roles="Administator, moderator, teacher")]
    public class LectureController : Controller
    {
        //
        // GET: /teacher/Lecture/

        public ActionResult Index()
        {
            return View();
        }

    }
}
