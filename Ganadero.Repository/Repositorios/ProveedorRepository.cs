using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganadero.Interfaces.Interfaces;
using Ganadero.Model.Entidades;
using GenerateDB;
namespace Ganadero.Repository.Repositorios
{
    public class ProveedorRepository: InterfaceProveedor
    {
           DBSystemContext entities;

        public ProveedorRepository(DBSystemContext entities)
        {
            this.entities = entities;
        }

        public List<Proveedor> All()
        {
            var result = from p in entities.Proveedores select p;
            return result.ToList();
        }

        public List<Proveedor> Allnombre()
        {
            using (DBSystemContext context = new DBSystemContext())
            {
                return (List<Proveedor>)context.Set<Proveedor>().ToList();
            }
        }

        public Proveedor Find(int id)
        {
            var result = from p in entities.Proveedores where p.IdProveedor == id select p;
            return result.FirstOrDefault();
        }

        public void Store(Proveedor proveedor)
        {
            entities.Proveedores.Add(proveedor);
            entities.SaveChanges();
        }

        public void Update(Proveedor proveedor)
        {
            var result = (from p in entities.Proveedores where p.IdProveedor == proveedor.IdProveedor select p).First();

            result.Ruc = proveedor.Ruc;

            result.Nombre = proveedor.Nombre;

            result.Telefono = proveedor.Telefono;

            result.Ciudad= proveedor.Ciudad;

            result.Correo= proveedor.Correo;

            result.PaginaWeb = proveedor.PaginaWeb;

            entities.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = (from p in entities.Proveedores where p.IdProveedor == id select p).First();
            entities.Proveedores.Remove(result);
            entities.SaveChanges();
        }

        public List<Proveedor> ByQueryAll(string query)
        {
            var dbQuery = (from p in entities.Proveedores select p);

            if (!String.IsNullOrEmpty(query))
                dbQuery = dbQuery.Where(o => o.Nombre.Contains(query) || o.Ruc.Contains(query));

            return dbQuery.ToList();
        }
    }
}
