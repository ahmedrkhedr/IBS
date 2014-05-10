using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBPRJCTA.Controllers
{
    public class SeasonController : Controller
    {
        //
        // GET: /Season/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllSeasons()
        {
            return Json(new Season().GetAllSeasons(), "text/html", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }        
    }
}
