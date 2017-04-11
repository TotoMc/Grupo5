using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganadero.BussinesEntities;

namespace Ganadero.Repository.Interfaces
{
    public interface InterfaceProveedor
    {
        List<Proveedor> All();
        List<Proveedor> Allnombre();
        
        Proveedor Find(int id);

        void Store(Proveedor proveedor);

        void Update(Proveedor proveedor);

        void Delete(int id);

        List<Proveedor> ByQueryAll(string query);
    }
}
