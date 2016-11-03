using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project.DAL;
using Project.Model;

namespace Project.WebAPI.Controllers
{
    public class VehicleModelController : Controller
    {
        private VehicleContext db = new VehicleContext();

        // GET: VehicleModel
        public ActionResult Index()
        {
            var vehicleModel = db.VehicleModel.Include(v => v.VehicleMake);
            return View(vehicleModel.ToList());
        }

        // GET: VehicleModel/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleModel vehicleModel = db.VehicleModel.Find(id);
            if (vehicleModel == null)
            {
                return HttpNotFound();
            }
            return View(vehicleModel);
        }

        // GET: VehicleModel/Create
        public ActionResult Create()
        {
            ViewBag.VehicleMakeId = new SelectList(db.VehicleMakes, "VehicleMakeId", "Name");
            return View();
        }

        // POST: VehicleModel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VehicleModelId,VehicleMakeId,Model,Abrv")] VehicleModel vehicleModel)
        {
            if (ModelState.IsValid)
            {
                vehicleModel.VehicleModelId = Guid.NewGuid();
                db.VehicleModel.Add(vehicleModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.VehicleMakeId = new SelectList(db.VehicleMakes, "VehicleMakeId", "Name", vehicleModel.VehicleMakeId);
            return View(vehicleModel);
        }

        // GET: VehicleModel/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleModel vehicleModel = db.VehicleModel.Find(id);
            if (vehicleModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.VehicleMakeId = new SelectList(db.VehicleMakes, "VehicleMakeId", "Name", vehicleModel.VehicleMakeId);
            return View(vehicleModel);
        }

        // POST: VehicleModel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VehicleModelId,VehicleMakeId,Model,Abrv")] VehicleModel vehicleModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicleModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VehicleMakeId = new SelectList(db.VehicleMakes, "VehicleMakeId", "Name", vehicleModel.VehicleMakeId);
            return View(vehicleModel);
        }

        // GET: VehicleModel/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleModel vehicleModel = db.VehicleModel.Find(id);
            if (vehicleModel == null)
            {
                return HttpNotFound();
            }
            return View(vehicleModel);
        }

        // POST: VehicleModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            VehicleModel vehicleModel = db.VehicleModel.Find(id);
            db.VehicleModel.Remove(vehicleModel);
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
