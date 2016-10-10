using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIrtualLabolatory.Web.Areas.administration.Controllers
{

    [Authorize(Roles = "Administator")]
    public class SupportController : Controller
    {
        //
        // GET: /administration/Support/

        public ActionResult Index()
        {
            return View();
        }

    }
}
