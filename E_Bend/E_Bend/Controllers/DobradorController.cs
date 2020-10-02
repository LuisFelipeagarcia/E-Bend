using E_Bend.Context;
using E_Bend.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace E_Bend.Controllers
{
    public class DobradorController : Controller
        
    {
        private readonly Contexto db = new Contexto();

        // GET: Dobrador
        public ActionResult Index()
        {
            var dobradores = db.Dobradores.Include(a => a.Equipe);
            return View(dobradores.ToList());
        }

        #region Create
        //GET: Create
        public ActionResult Create()
        {
            
            ViewBag.EquipeId = new SelectList(db.Equipes, "Id", "Equipe");
            
            return View();
        }
        //POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DobradorModel dobradorModel)
        {
            if (ModelState.IsValid)
            {
                db.Dobradores.Add(dobradorModel);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.EquipeId = new SelectList(db.Equipes, "Id", "Equipe", dobradorModel.EquipeId);
            return View(dobradorModel);
        }
        #endregion

        #region Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            DobradorModel dobradorModel = db.Dobradores.Find(id);
            if (dobradorModel == null)
            {
                return HttpNotFound();
            }
            return View(dobradorModel);
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
            DobradorModel dobradorModel = db.Dobradores.Find(id);
            if (dobradorModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.EquipeId = new SelectList(db.Equipes, "Id", "Equipe", dobradorModel.EquipeId);
            return View(dobradorModel);
        }

        //POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DobradorModel dobradorModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dobradorModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.EquipeId = new SelectList(db.Equipes, "Id", "Equipe", dobradorModel.EquipeId);
            return View(dobradorModel);
        }
        #endregion

        #region Delete
        //GET: Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            DobradorModel dobradorModel = db.Dobradores.Find(id);
            if (dobradorModel == null)
            {
                return HttpNotFound();
            }
            return View(dobradorModel);
        }

        //POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DobradorModel dobradorModel = db.Dobradores.Find(id);
            db.Dobradores.Remove(dobradorModel);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}