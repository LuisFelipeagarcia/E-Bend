using E_Bend.Context;
using E_Bend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace E_Bend.Controllers
{
    public class EquipeController : Controller
    {
        private readonly Contexto db = new Contexto();

        // GET: Equipe
        public ActionResult Index()
        {
            
            return View(db.Equipes.ToList());
        }

        #region Create

        //GET: Create
        public ActionResult Create()
        {
            
            return View();
        }

        //POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EquipeModel equipeModel)
        {
            if (ModelState.IsValid)
            {
                db.Equipes.Add(equipeModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipeModel);
        }
        #endregion

        #region Details
        // GET: Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            EquipeModel equipeModel = db.Equipes.Find(id);
            if (equipeModel == null)
            {
                return HttpNotFound();
            }
            return View(equipeModel);
        }
        #endregion

        #region Edit
        //GET: Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            EquipeModel equipeModel = db.Equipes.Find(id);
            if (equipeModel == null)
            {
                return HttpNotFound();
            }
            return View(equipeModel);
        }

        //POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EquipeModel equipeModel)
        {
            if (ModelState.IsValid)
            {
                db.Equipes.Add(equipeModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipeModel);
        }
        #endregion

        #region Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipeModel equipeModel = db.Equipes.Find(id);
            if (equipeModel == null)
            {
                return HttpNotFound();
            }
            return View(equipeModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EquipeModel equipeModel = db.Equipes.Find(id);
            db.Equipes.Remove(equipeModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

    }
}