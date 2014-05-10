using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBSApplication.Controllers
{
    public class SeasonLockupController : Controller
    {
        //
        // GET: /SeasonStatusLockups/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllSeasonsLockups()
        {
            return Json(new SeasonLockup().GetAllSeasonsLockups(), "text/html", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }        

    }
}
