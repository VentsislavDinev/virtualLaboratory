using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIrtualLabolatory.Web.Areas.administration.Controllers
{

    [Authorize(Roles = "Administator")]
    public class ForumController : Controller
    {
        //
        // GET: /administration/Forum/

        public ActionResult Index()
        {
            return View();
        }

    }
}
