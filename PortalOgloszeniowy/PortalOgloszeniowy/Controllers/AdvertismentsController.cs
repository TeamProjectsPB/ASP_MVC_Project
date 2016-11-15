using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PortalOgloszeniowy.Models;

namespace PortalOgloszeniowy.Controllers
{
    public class AdvertismentsController : Controller
    {
        private Entities2 db = new Entities2();

        // GET: Advertisments
        public ActionResult Index()
        {
            var advertisment = db.Advertisment.Include(a => a.City).Include(a => a.Category).Include(a => a.AspNetUsers);
            return View(advertisment.ToList());
        }

        // GET: Advertisments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertisment advertisment = db.Advertisment.Find(id);
            if (advertisment == null)
            {
                return HttpNotFound();
            }
            return View(advertisment);
        }

        // GET: Advertisments/Create
        public ActionResult Create()
        {
            ViewBag.CityId = new SelectList(db.City, "Id", "Name");
            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name");
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email");
            return View();
        }

        // POST: Advertisments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,CategoryId,CityId,Visits,IsPremium,IsActive,Pub_Time,Exp_Time,Title,Description")] Advertisment advertisment)
        {
            if (ModelState.IsValid)
            {
                db.Advertisment.Add(advertisment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CityId = new SelectList(db.City, "Id", "Name", advertisment.CityId);
            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", advertisment.CategoryId);
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email", advertisment.UserId);
            return View(advertisment);
        }

        // GET: Advertisments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertisment advertisment = db.Advertisment.Find(id);
            if (advertisment == null)
            {
                return HttpNotFound();
            }
            ViewBag.CityId = new SelectList(db.City, "Id", "Name", advertisment.CityId);
            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", advertisment.CategoryId);
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email", advertisment.UserId);
            return View(advertisment);
        }

        // POST: Advertisments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,CategoryId,CityId,Visits,IsPremium,IsActive,Pub_Time,Exp_Time,Title,Description")] Advertisment advertisment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advertisment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityId = new SelectList(db.City, "Id", "Name", advertisment.CityId);
            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", advertisment.CategoryId);
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email", advertisment.UserId);
            return View(advertisment);
        }

        // GET: Advertisments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertisment advertisment = db.Advertisment.Find(id);
            if (advertisment == null)
            {
                return HttpNotFound();
            }
            return View(advertisment);
        }

        // POST: Advertisments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Advertisment advertisment = db.Advertisment.Find(id);
            db.Advertisment.Remove(advertisment);
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
