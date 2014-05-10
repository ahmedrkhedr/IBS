using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBPRJCTA.Controllers
{
    public class SeasonLockupsController : Controller
    {
        //
        // GET: /SeasonStatusLockups/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllSeasonStatusLockups()
        {
            return Json(new SeasonsLockups().GetAllSeasonLockups(), "text/html", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }        

    }
}
