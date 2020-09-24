using E_Bend.Context;
using E_Bend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Bend.Controllers
{
    public class EquipeController : Controller
    {
        private Contexto db = new Contexto();

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
    }
}