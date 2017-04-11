using Ganadero.Model.Entidades;
using Ganadero.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenerateDB;

namespace Ganadero.Repository.Repositorios
{
     public class ProductoRepository:InterfaceProducto
    {
         DBSystemContext entities;
     
        public ProductoRepository(DBSystemContext entities)
        {
            this.entities = entities;
        }

        public List<Producto> All()
        {
            var result = from p in entities.Productos select p;
            return result.ToList();
        }
        public List<Producto> Allnombre()
        {
            using (DBSystemContext context = new DBSystemContext())
            {
                return (List<Producto>)context.Set<Producto>().ToList();
            }
        }


        public void Store(Producto producto)
        {
            entities.Productos.Add(producto);
            entities.SaveChanges();
        }
        public Producto Find(int IdProducto)
        {
           
            var result = from p in entities.Productos.Include("Categoria") where p.IdProducto == IdProducto select p;
            return result.FirstOrDefault();
        }


        public void Update(Producto producto)
        {
            var result = (from p in entities.Productos where p.IdProducto == producto.IdProducto select p).First();

            result.NombreProducto = producto.NombreProducto;
            result.Precio = producto.Precio;
            result.Marca = producto.Marca;
            result.IDCategoria = producto.IDCategoria;
            
            
            entities.SaveChanges();
        }


        public void Delete(int id)
        {
            var result = (from p in entities.Productos where p.IdProducto == id select p).First();
            entities.Productos.Remove(result);
            entities.SaveChanges();
        }


        public List<Producto> ByQueryAll(string query)
        {
            var dbQuery = (from p in entities.Productos.Include("Categoria") select p);

            if (!String.IsNullOrEmpty(query))
                dbQuery = dbQuery.Where(o => o.NombreProducto.Contains(query) );
            return dbQuery.ToList();
        }
    }
}
