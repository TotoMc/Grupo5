using Ganadero.BussinesEntities;
using Ganadero.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganadero.Repository.Repositorios
{
      public class CategoriaRepository:InterfaceCategoria
    {
        Respository.VeterinariaContext entities;
 
          public CategoriaRepository(Respository.VeterinariaContext entities)
        {
            this.entities = entities;
        }
          public Categoria Find(int id)
          {
              var result = from p in entities.Categorias where p.IdCategoria == id select p;
              return result.FirstOrDefault();
          }


         public List<Categoria> All()
          {
              using (Respository.VeterinariaContext context = new Respository.VeterinariaContext())
              {
                  return (List<Categoria>)context.Set<Categoria>().ToList();
              }
              //var result = from c in entities.Categorias select c;
              //return result.ToList();
          }

         public List<Categoria> ByQueryAll(string query,string i, string s)
         {
             var dbQuery = (from c in entities.Categorias select c);

             if (!String.IsNullOrEmpty(query))
                 dbQuery = dbQuery.Where(o => o.Descripcion.Contains(query));
             return dbQuery.ToList();
         }
    }
}
