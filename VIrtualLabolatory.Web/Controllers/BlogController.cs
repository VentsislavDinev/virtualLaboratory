using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualLaboratory.Models;

namespace VIrtualLabolatory.Web.Controllers
{
    public class BlogController : Controller
    {

        private readonly SofiaDb db = new SofiaDb();
        //
        // GET: /Blog/

        public ActionResult Index()
        {

            return View();
        }


        public ActionResult readPost()
        {
            return View();
        }

        public ActionResult Comment()
        {
            return PartialView();
        }

        public ActionResult AddComent()
        {
            return Redirect("/");
        }

    }
}
