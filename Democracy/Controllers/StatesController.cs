using Democracy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Democracy.Controllers
{
    [Authorize]
    public class StatesController : Controller
    {

        private DemocracyContext db = new DemocracyContext();
        // GET: States
        #region Index
        [HttpGet]
        public ActionResult Index()
        {
            return View(db.States.ToList());
        }
        #endregion

        #region Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(State state)
        {
            if (!ModelState.IsValid)
            {
                return View(state);
            }
            db.States.Add(state);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region Edit
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var state = db.States.Find(id);
            if (state == null)
            {
                return RedirectToAction("Index");
            }
            return View(state);
        }
        [HttpPost]
        public ActionResult Edit(State state)
        {
            if (!ModelState.IsValid)
            {
                return View(state);
            }
            db.Entry(state).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region Details
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var state = db.States.Find(id);
            if (state == null)
            {
                return RedirectToAction("Index");
            }
            return View(state);
        }
        #endregion

        #region Delete
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var state = db.States.Find(id);
            if (state == null)
            {
                return RedirectToAction("Index");
            }
            return View(state);
        }

        [HttpPost]
        public ActionResult Delete(int id, State state)
        {
            state = db.States.Find(id);
            if(state == null)
            {
                return HttpNotFound();
            }
            db.States.Remove(state);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region Dispose
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        } 
        #endregion
    }
}