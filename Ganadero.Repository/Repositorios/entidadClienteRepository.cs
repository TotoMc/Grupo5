using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganadero.BussinesEntities;
using Ganadero.Repository.Interfaces;

namespace Ganadero.Repository.Repositorios
{
    public class entidadClienteRepository:InterfaceEntidadCliente
    {
         VeterinariaContext entities;

         public entidadClienteRepository(DBSystemContext entities)
        {
            this.entities = entities;
        }

        public entidadCliente Find(int id)
        {
            var result = from p in entities.entidadCliente where p.id == id select p;
            return result.FirstOrDefault();
        }

        public List<entidadCliente> All()
        {
            using (DBSystemContext context = new DBSystemContext())
            {
                return (List<entidadCliente>)context.Set<entidadCliente>().ToList();
            }
        }
    }
}
