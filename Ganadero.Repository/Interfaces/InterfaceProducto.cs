using Ganadero.BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ganadero.Repository.Interfaces
{
     public interface InterfaceProducto
    {
         List<Producto>All();
         List<Producto> Allnombre();
         Producto Find(int id);
         void Store(Producto producto);
         void Update(Producto producto);
         void Delete(int id);
         List<Producto> ByQueryAll(string query);

    }
}
