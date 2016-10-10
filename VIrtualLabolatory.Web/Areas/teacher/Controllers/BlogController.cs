using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIrtualLabolatory.Web.Areas.teacher.Controllers
{
    [Authorize(Roles = "Administator, moderator, teacher")]
    public class BlogController : Controller
    {
        //
        // GET: /teacher/Blog/

        public ActionResult Index()
        {
            return View();
        }

    }
}
