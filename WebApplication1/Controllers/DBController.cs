using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DBController : Controller
    {
        // GET: DB
        DbContextDatabase db = new DbContextDatabase();
        public ActionResult Index()
        {
            return View(db.brevets.ToList());
        }

        public ActionResult Itentification()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Itentification(Domaine d)
        {
            Session["Here"] = null;
            
            if (ModelState.IsValid)
            {
                var i = db.domaines.SingleOrDefault(c => c.Nom_domaine == d.Nom_domaine && c.motdepasse == d.motdepasse);
                if (i != null)
                {
                    Session["Here"] = "WeAreHere";
                    return RedirectToAction("LogIn");

                }
            }
            return View(d);

        }

        public ActionResult LogIn()
        {
            if (Session["Here"] != null)
            {
                return View();
            }
            return RedirectToAction("Itentification");
        }

        public JsonResult GetTimeConnection(string EndTime)
        {

            Domaine d = new Domaine();
            
            d.Time = EndTime;
            d.Nom_domaine = "bla";
            d.motdepasse = "bla";
            db.domaines.Add(d);
            db.SaveChanges();
            return Json(EndTime, JsonRequestBehavior.AllowGet);

        }

    }
}