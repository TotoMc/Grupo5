using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganadero.BussinesEntities;

namespace Ganadero.Repository.Interfaces
{
   public  interface InterfaceVenta
    {
        List<Venta> All();
        List<Venta> Allnombre();
        Venta Find(int id);
        void Store(Venta venta);
        void Update(Venta venta);
        void Delete(int id);
        List<Venta> ByQueryAll(int  query);
    }
}
