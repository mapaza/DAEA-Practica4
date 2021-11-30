using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace PR4.Controllers
{
    public class PrestamoController : Controller
    {
        // GET: Prestamo
        #region Contexto


        private practica4Entities _contexto;

        public practica4Entities contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new practica4Entities();
                return _contexto;
            }
        }
        #endregion

        public ActionResult Index()
        {
            
            return View(contexto.prestamos.ToList());
      
        }

        public ActionResult Create()
        {
            //Generar ID automático
            Random rd = new Random();
            int rand_num = rd.Next(1001, 1999);
            ViewBag.id_generado = rand_num;

            //Valores de Libro
   
            return View();
        }

        [HttpPost]
        public ActionResult Create(prestamos nuevoPrestamo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.prestamos.Add(nuevoPrestamo);
                    contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(nuevoPrestamo);
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            prestamos categoriaEditar = contexto.prestamos.Find(id);

            if (categoriaEditar == null)
                return HttpNotFound();

            return View(categoriaEditar);
        }

        [HttpPost]
        public ActionResult Edit(prestamos PrestamoEditar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Entry(PrestamoEditar).State = EntityState.Modified;
                    contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(PrestamoEditar);
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

           prestamos prestamoEliminar = contexto.prestamos.Find(id);

            if (prestamoEliminar == null)
                return HttpNotFound();

            return View(prestamoEliminar);
        }

        [HttpPost]
        public ActionResult Delete(int? id, prestamos Categoria1)
        {
            try
            {
                prestamos prestamoEliminar = new prestamos();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    prestamoEliminar = contexto.prestamos.Find(id);

                    if (prestamoEliminar == null)
                        return HttpNotFound();

                    contexto.prestamos.Remove(prestamoEliminar);
                    contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(prestamoEliminar);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            //var autorPorPrestamo = from p in contexto.libro
            //                            orderby p.IdLibro ascending
            //                            where p.IdLibro == id
            //                            select p;
            //return View(autorPorPrestamo.ToList());
            var libroPorPrestamo = from p in contexto.libro
                                   orderby p.IdLibro ascending
                                   where p.IdLibro == id
                                   select p;
            return View(libroPorPrestamo.ToList());
        }

    }
}