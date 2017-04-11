using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganadero.Interfaces.Interfaces;
using Ganadero.Model.Entidades;
using GenerateDB;

namespace Ganadero.Repository.Repositorios
{
   public class ServicioRepository : InterfaceServicio
    {
        DBSystemContext entities;

        public ServicioRepository(DBSystemContext entities)
        {
            this.entities = entities;
        }

        public List<Servicio> All()
        {
            var result = from p in entities.Servicios select p;
            return result.ToList();
        }

        public void Store(Servicio servicio)
        {
            entities.Servicios.Add(servicio);
            entities.SaveChanges();
        }



        public Servicio Find(int id)
        {
            var result = from p in entities.Servicios where p.Id_servicio == id select p;
            return result.FirstOrDefault();
        }


        public void Update(Servicio servicio)
        {
            var result = (from p in entities.Servicios where p.Id_servicio == servicio.Id_servicio select p).First();

            result.NombreServicio = servicio.NombreServicio;

            result.Precio = servicio.Precio;

            result.Descripcion = servicio.Descripcion;

            entities.SaveChanges();
        }


        public void Delete(int id)
        {
            var result = (from p in entities.Servicios where p.Id_servicio == id select p).First();
            entities.Servicios.Remove(result);
            entities.SaveChanges();
        }


        public List<Servicio> ByQueryAll(string query)
        {
            var dbQuery = (from p in entities.Servicios select p);

            if (!String.IsNullOrEmpty(query))
                dbQuery = dbQuery.Where(o => o.NombreServicio.Contains(query) || o.Descripcion.Contains(query));

            return dbQuery.ToList();
        }
    }
}
