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
    public class LeagueYearsController : Controller
    {
        private GolfLeagueDBEntities db = new GolfLeagueDBEntities();

        // GET: LeagueYears
        public ActionResult Index()
        {
            var leagueYears = db.LeagueYears.Include(l => l.HandicapMethod).Include(l => l.League).Include(l => l.MaxScore1).Include(l => l.PointSytem);
            return View(leagueYears.ToList());
        }

        // GET: LeagueYears/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeagueYear leagueYear = db.LeagueYears.Find(id);
            if (leagueYear == null)
            {
                return HttpNotFound();
            }
            return View(leagueYear);
        }

        // GET: LeagueYears/Create
        public ActionResult Create()
        {
            ViewBag.HandicapID = new SelectList(db.HandicapMethods, "HandicapID", "Method");
            ViewBag.LeagueID = new SelectList(db.Leagues, "LeagueID", "LeagueName");
            ViewBag.MaxScoreID = new SelectList(db.MaxScores, "MaxScoreID", "MaxScoreType");
            ViewBag.PointID = new SelectList(db.PointSytems, "PointID", "SystemName");
            return View();
        }

        // POST: LeagueYears/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "YearID,MaxScore,LeagueID,HandicapID,PointID,MaxScoreID,TrackPutts")] LeagueYear leagueYear)
        {
            if (ModelState.IsValid)
            {
                db.LeagueYears.Add(leagueYear);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HandicapID = new SelectList(db.HandicapMethods, "HandicapID", "Method", leagueYear.HandicapID);
            ViewBag.LeagueID = new SelectList(db.Leagues, "LeagueID", "LeagueName", leagueYear.LeagueID);
            ViewBag.MaxScoreID = new SelectList(db.MaxScores, "MaxScoreID", "MaxScoreType", leagueYear.MaxScoreID);
            ViewBag.PointID = new SelectList(db.PointSytems, "PointID", "SystemName", leagueYear.PointID);
            return View(leagueYear);
        }

        // GET: LeagueYears/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeagueYear leagueYear = db.LeagueYears.Find(id);
            if (leagueYear == null)
            {
                return HttpNotFound();
            }
            ViewBag.HandicapID = new SelectList(db.HandicapMethods, "HandicapID", "Method", leagueYear.HandicapID);
            ViewBag.LeagueID = new SelectList(db.Leagues, "LeagueID", "LeagueName", leagueYear.LeagueID);
            ViewBag.MaxScoreID = new SelectList(db.MaxScores, "MaxScoreID", "MaxScoreType", leagueYear.MaxScoreID);
            ViewBag.PointID = new SelectList(db.PointSytems, "PointID", "SystemName", leagueYear.PointID);
            return View(leagueYear);
        }

        // POST: LeagueYears/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "YearID,MaxScore,LeagueID,HandicapID,PointID,MaxScoreID,TrackPutts")] LeagueYear leagueYear)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leagueYear).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HandicapID = new SelectList(db.HandicapMethods, "HandicapID", "Method", leagueYear.HandicapID);
            ViewBag.LeagueID = new SelectList(db.Leagues, "LeagueID", "LeagueName", leagueYear.LeagueID);
            ViewBag.MaxScoreID = new SelectList(db.MaxScores, "MaxScoreID", "MaxScoreType", leagueYear.MaxScoreID);
            ViewBag.PointID = new SelectList(db.PointSytems, "PointID", "SystemName", leagueYear.PointID);
            return View(leagueYear);
        }

        // GET: LeagueYears/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeagueYear leagueYear = db.LeagueYears.Find(id);
            if (leagueYear == null)
            {
                return HttpNotFound();
            }
            return View(leagueYear);
        }

        // POST: LeagueYears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LeagueYear leagueYear = db.LeagueYears.Find(id);
            db.LeagueYears.Remove(leagueYear);
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
