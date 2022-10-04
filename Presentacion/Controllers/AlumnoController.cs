using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocio;
using Negocio.WCFAlumnos;

namespace Presentacion.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        NAlumno OAlumno = new NAlumno();
        Alumnos alumno = new Alumnos();

        public ActionResult Index()
        {
            
            List <Alumnos> Lista= OAlumno.Consultar();

            
            return View(Lista);
        }

        public ActionResult _AportacionesIMSS(int id)
        {
            AportacionesIMSS aportacciones = OAlumno.ConsultarIMSS(id);
           

            return PartialView(aportacciones);
        }
        public ActionResult _TablaISR(int id)
        {
            ItemTablaISR isr = OAlumno.ConsultarISR(id);

            return PartialView(isr);
        }


        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            //Consultar uno
         
          
          
            alumno = OAlumno.Conasultaruno(id);
           


            return View(alumno);
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Alumno/Create
        [HttpPost]
       
        public ActionResult Create(Alumnos alumnos)
        {
            try
            {  // TODO: Add insert logic here

                OAlumno.Agregar(alumnos);
              

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int id) => View (OAlumno.Conasultaruno(id));
     

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(Alumnos alumnos)
        {
            try
            {
                 OAlumno.Actualizar(alumnos);
                 

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {

           alumno =  OAlumno.Conasultaruno(id);

            return View(alumno);
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Alumnos alumno)
        {
            try
            {
                // TODO: Add delete logic here

                OAlumno.Eliminar(id);  
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
