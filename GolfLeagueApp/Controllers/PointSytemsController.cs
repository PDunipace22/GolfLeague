using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GolfLeagueApp.Models;

namespace GolfLeagueApp.Controllers
{
    public class PointSytemsController : Controller
    {
        private GolfLeagueDBEntities db = new GolfLeagueDBEntities();

        // GET: PointSytems
        public ActionResult Index()
        {
            return View(db.PointSytems.ToList());
        }

        // GET: PointSytems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PointSytem pointSytem = db.PointSytems.Find(id);
            if (pointSytem == null)
            {
                return HttpNotFound();
            }
            return View(pointSytem);
        }

        // GET: PointSytems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PointSytems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PointID,SystemName")] PointSytem pointSytem)
        {
            if (ModelState.IsValid)
            {
                db.PointSytems.Add(pointSytem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pointSytem);
        }

        // GET: PointSytems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PointSytem pointSytem = db.PointSytems.Find(id);
            if (pointSytem == null)
            {
                return HttpNotFound();
            }
            return View(pointSytem);
        }

        // POST: PointSytems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PointID,SystemName")] PointSytem pointSytem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pointSytem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pointSytem);
        }

        // GET: PointSytems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PointSytem pointSytem = db.PointSytems.Find(id);
            if (pointSytem == null)
            {
                return HttpNotFound();
            }
            return View(pointSytem);
        }

        // POST: PointSytems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PointSytem pointSytem = db.PointSytems.Find(id);
            db.PointSytems.Remove(pointSytem);
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
