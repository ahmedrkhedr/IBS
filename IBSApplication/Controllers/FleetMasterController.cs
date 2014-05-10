using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBSApplication.Controllers
{
    public class FleetMasterController : Controller
    {
        //
        // GET: /FleetMaster/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetFleetByFleetNumber(string fleetNumber)
        {
            return Json(new FleetMaster().GetFleetByFleetNumber(fleetNumber), "text/html", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }    
    }
}
