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
    public class VentaRepository:InterfaceVenta
    {
        DBSystemContext entities;
        public VentaRepository(DBSystemContext entities)
        {

            this.entities = entities;
        }
        public List<Venta> All()
        {
            var result = from p in entities.Ventas select p;
            return result.ToList();
        }

        public List<Venta> Allnombre()
        {
            using (DBSystemContext context = new DBSystemContext())
            {
                return (List<Venta>)context.Set<Venta>().ToList();
            }
        }

        public Venta Find(int id)
        {
            var result = from p in entities.Ventas where p.ventaID ==id select p;
            return result.FirstOrDefault();
        }

        public void Store(Venta venta)
        {
            entities.Ventas.Add(venta);
            entities.SaveChanges();
        }

        public void Update(Venta venta)
        {
            var result = (from p in entities.Ventas where p.ventaID == venta.ventaID select p).First();

            
            result.tipocomprobante = venta.tipocomprobante;
            result.identiti = venta.identiti;
            result.fecha = venta.fecha;
            result.tipocomprobante=venta.tipocomprobante;
            result.total=venta.total;
            result.detalleventa = result.detalleventa;
            result.estado = result.estado;
            
            entities.SaveChanges();
        
        }

        public void Delete(int id)
        {
                   var result = (from p in entities.Ventas where p.ventaID == id select p).First();
            entities.Ventas.Remove(result);
            entities.SaveChanges();
        }

        public List<Venta> ByQueryAll(int query)
        {
            
            var dbQuery = (from p in entities.Ventas select p);

            if (query!=null)
                dbQuery = dbQuery.Where(o => o.ventaID==query);
            return dbQuery.ToList();
        }
    }
}
