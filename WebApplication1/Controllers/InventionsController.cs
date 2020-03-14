using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;


namespace WebApplication1.Controllers
{
    public class InventionsController : Controller
    {
        private OMPIC_DBEntities db = new OMPIC_DBEntities();

        // GET: Inventions
        public ActionResult Index()
        {
            return View(db.Inventions.ToList());
        }

        // GET: Inventions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventions invention = db.Inventions.Find(id);
            if (invention == null)
            {
                return HttpNotFound();
            }
            return View(invention);
        }

        // GET: Inventions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inventions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Num_invention,description,resume")] Inventions invention)
        {
            if (ModelState.IsValid)
            {
                db.Inventions.Add(invention);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(invention);
        }

        // GET: Inventions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventions invention = db.Inventions.Find(id);
            if (invention == null)
            {
                return HttpNotFound();
            }
            return View(invention);
        }

        // POST: Inventions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Num_invention,description,resume")] Inventions invention)
        {
            if (ModelState.IsValid)
            {
                db.Entry(invention).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(invention);
        }

        // GET: Inventions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventions invention = db.Inventions.Find(id);
            if (invention == null)
            {
                return HttpNotFound();
            }
            return View(invention);
        }

        // POST: Inventions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inventions invention = db.Inventions.Find(id);
            db.Inventions.Remove(invention);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
