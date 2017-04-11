using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganadero.BussinesEntities;

namespace Ganadero.Repository.Interfaces
{
     public interface InterfaceCategoria
    {
         Categoria Find(int id);
         List<Categoria> All();
         List<Categoria> ByQueryAll(string query ,string i,string s);
    }
}
