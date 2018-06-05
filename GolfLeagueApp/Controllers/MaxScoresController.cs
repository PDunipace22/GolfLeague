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
    public class MaxScoresController : Controller
    {
        private GolfLeagueDBEntities db = new GolfLeagueDBEntities();

        // GET: MaxScores
        public ActionResult Index()
        {
            return View(db.MaxScores.ToList());
        }

        // GET: MaxScores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaxScore maxScore = db.MaxScores.Find(id);
            if (maxScore == null)
            {
                return HttpNotFound();
            }
            return View(maxScore);
        }

        // GET: MaxScores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MaxScores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaxScoreID,MaxScoreType")] MaxScore maxScore)
        {
            if (ModelState.IsValid)
            {
                db.MaxScores.Add(maxScore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(maxScore);
        }

        // GET: MaxScores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaxScore maxScore = db.MaxScores.Find(id);
            if (maxScore == null)
            {
                return HttpNotFound();
            }
            return View(maxScore);
        }

        // POST: MaxScores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaxScoreID,MaxScoreType")] MaxScore maxScore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maxScore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maxScore);
        }

        // GET: MaxScores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaxScore maxScore = db.MaxScores.Find(id);
            if (maxScore == null)
            {
                return HttpNotFound();
            }
            return View(maxScore);
        }

        // POST: MaxScores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MaxScore maxScore = db.MaxScores.Find(id);
            db.MaxScores.Remove(maxScore);
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
