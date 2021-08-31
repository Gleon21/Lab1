using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using laboratorio.Models;

namespace laboratorio.Controllers
{
    public class NotasController : Controller
    {
        // GET: Notas
        NotasEntities db = new NotasEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "NombreEstudiante,lab1,lab2,lab3,par1,par2,par3")] TblNotasEstudiante tbl)
        {
           
            if (ModelState.IsValid)
            { 
                
                Random rnd = new Random();
                int nr = rnd.Next();
                tbl.TblNotasEstudianteId = nr;
                
                db.TblNotasEstudiante.Add(tbl);
                db.SaveChanges();
                return RedirectToAction("./Resultado/"+nr);



            }

            return View(tbl);
        }
        public ActionResult  Resultado(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblNotasEstudiante tbl = db.TblNotasEstudiante.Find(id);
            if (tbl == null)
            {
                return HttpNotFound();
            }
            return View(tbl);
        }
        public ActionResult Tablon()
        {
            return View(db.TblNotasEstudiante.ToList());
        }
    }
}