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
    public class HandicapMethodsController : Controller
    {
        private GolfLeagueDBEntities db = new GolfLeagueDBEntities();

        // GET: HandicapMethods
        public ActionResult Index()
        {
            return View(db.HandicapMethods.ToList());
        }

        // GET: HandicapMethods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HandicapMethod handicapMethod = db.HandicapMethods.Find(id);
            if (handicapMethod == null)
            {
                return HttpNotFound();
            }
            return View(handicapMethod);
        }

        // GET: HandicapMethods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HandicapMethods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HandicapID,Method")] HandicapMethod handicapMethod)
        {
            if (ModelState.IsValid)
            {
                db.HandicapMethods.Add(handicapMethod);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(handicapMethod);
        }

        // GET: HandicapMethods/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HandicapMethod handicapMethod = db.HandicapMethods.Find(id);
            if (handicapMethod == null)
            {
                return HttpNotFound();
            }
            return View(handicapMethod);
        }

        // POST: HandicapMethods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HandicapID,Method")] HandicapMethod handicapMethod)
        {
            if (ModelState.IsValid)
            {
                db.Entry(handicapMethod).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(handicapMethod);
        }

        // GET: HandicapMethods/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HandicapMethod handicapMethod = db.HandicapMethods.Find(id);
            if (handicapMethod == null)
            {
                return HttpNotFound();
            }
            return View(handicapMethod);
        }

        // POST: HandicapMethods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HandicapMethod handicapMethod = db.HandicapMethods.Find(id);
            db.HandicapMethods.Remove(handicapMethod);
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
