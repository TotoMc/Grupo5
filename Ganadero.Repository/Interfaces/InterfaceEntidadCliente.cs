using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganadero.BussinesEntities;

namespace Ganadero.Repository.Interfaces
{
   public  interface InterfaceEntidadCliente
    {
        entidadCliente Find(int id);
        List<entidadCliente> All();
    }
}
