using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using Negocio.WCFAlumnos;

namespace Negocio
{
    public class NAlumno
    {
        InstitutoTichEntities _DbContext = new InstitutoTichEntities();
        Alumnos alumnos = new Alumnos();
       
        public List<Alumnos> Consultar() => _DbContext.Alumnos.ToList();
        WCFAlumnosClient obj = new WCFAlumnosClient();
        public ItemTablaISR ConsultarISR(int id)
        {
            return obj.CalcularISR(id);
        }

        public Negocio.WCFAlumnos.AportacionesIMSS ConsultarIMSS(int id)
        {
            //_DbContext.Configuration.LazyLoadingEnabled = true;
            //return obj.CalcularIMSS (id);
            Negocio.WCFAlumnos.AportacionesIMSS variable = obj.CalcularIMSS (id);
            return variable;
        }
    

        public Alumnos Conasultaruno(int id)
        {


            alumnos = _DbContext.Alumnos.Find(id);

            return alumnos;
        }

        public void Agregar(Alumnos alumnos)
        {




            _DbContext.Alumnos.Add(alumnos);
            _DbContext.SaveChanges();
        }

        public void Actualizar (Alumnos alumnos)
        {
            
           
           

            _DbContext.Entry(alumnos).State = EntityState.Modified;
            _DbContext.SaveChanges();
            
            
        }
        
        public void Eliminar(int id)
        {
            alumnos = _DbContext.Alumnos.Find(id);
            _DbContext.Alumnos.Remove(alumnos);
            _DbContext.SaveChanges();


        }
    }
}
