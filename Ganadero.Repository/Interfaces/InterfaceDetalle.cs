using Ganadero.BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganadero.Repository.Interfaces
{
    public interface InterfaceDetalle
    {
        List<DetalleVenta>ByQueryAll(int  id);
    }
}
