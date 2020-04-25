using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MedicalSystem.Models;

namespace MedicalSystem.Controllers
{
    public class ManageController : Controller
    {
        private DBSMEntities db = new DBSMEntities();

        // GET: Manage
        public ActionResult Index()
        {
            return View(db.managements.ToList());
        }

        // GET: Manage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            management management = db.managements.Find(id);
            if (management == null)
            {
                return HttpNotFound();
            }
            return View(management);
        }

        // GET: Manage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,roomno,products,productmodel,available")] management management)
        {
            if (ModelState.IsValid)
            {
                db.managements.Add(management);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(management);
        }

        // GET: Manage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            management management = db.managements.Find(id);
            if (management == null)
            {
                return HttpNotFound();
            }
            return View(management);
        }

        // POST: Manage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,roomno,products,productmodel,available")] management management)
        {
            if (ModelState.IsValid)
            {
                db.Entry(management).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(management);
        }

        // GET: Manage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            management management = db.managements.Find(id);
            if (management == null)
            {
                return HttpNotFound();
            }
            return View(management);
        }

        // POST: Manage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            management management = db.managements.Find(id);
            db.managements.Remove(management);
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
