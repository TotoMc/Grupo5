using Ganadero.BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganadero.Repository.Interfaces
{
    public interface InterfaceLote {
    
         List<Lote>All();

         Lote Find(int id);
         void Store(Lote producto);
         void Update(Lote producto);
         void Delete(int id);
         List<Lote> ByQueryAll(DateTime? date1,DateTime? date2);
    }
}
