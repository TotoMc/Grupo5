using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganadero.BussinesEntities;

namespace Ganadero.Repository.Interfaces
{
    public interface InterfaceServicio
    {
        List<Servicio> All();

        Servicio Find(int id);

        void Store(Servicio servicio);

        void Update(Servicio servicio);

        void Delete(int id);

        List<Servicio> ByQueryAll(string query);
    }
}
