using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganadero.BussinesEntities;
using Ganadero.Repository.Interfaces;
using Ganadero.Respository;

namespace Ganadero.Repository.Repositorios
{
    public class DetalleRepository:InterfaceDetalle
    {
           VeterinariaContext entities;

          public DetalleRepository(VeterinariaContext entities)
        {
            this.entities = entities;
        }



          public List<DetalleVenta> ByQueryAll(int id)
          {
              var dbQuery = (from p in entities.DetalleVenta select p);

              if (id != null)
                  dbQuery = dbQuery.Where(o => o.detalleId == id);
              return dbQuery.ToList();
          }
    }
}
