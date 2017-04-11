using Ganadero.Interfaces.Interfaces;
using Ganadero.Model.Entidades;
using GenerateDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganadero.Repository.Repositorios
{
    public class LoteRepository:InterfaceLote
    {
         DBSystemContext entities;
     
        public LoteRepository(DBSystemContext entities)
        {
            this.entities = entities;
        }

        public List<Lote> All()
        {
            var result = from p in entities.Lotes select p;
            return result.ToList();
        }


        public void Store(Lote lote)
        {
            entities.Lotes.Add(lote);
            entities.SaveChanges();
        }
        public Lote Find(int  IDLote)
        {
            var result = from p in entities.Lotes.Include("Proveedor").Include("Producto") where p.IdLote == IDLote select p;
            return result.FirstOrDefault();
        }


        public void Update(Lote lote)
        {
            var result = (from p in entities.Lotes where p.IdLote == lote.IdLote select p).First();


            result.NroLote = lote.NroLote;
            result.idProducto = lote.idProducto;
            result.StockInicial = lote.StockInicial;
            result.FechaDeVencimiento = lote.FechaDeVencimiento;
            result.idProveedor = lote.idProveedor;
            entities.SaveChanges();
        }


        public void Delete(int id)
        {
            var result = (from p in entities.Lotes where p.IdLote == id select p).First();
            entities.Lotes.Remove(result);
            entities.SaveChanges();
        }


        public List<Lote> ByQueryAll(DateTime? date1, DateTime? date2)
        {
            var dbQuery = (from p in entities.Lotes.Include("Producto").Include("Proveedor") select p);

        
            if (date1 != null && date2==null)
                dbQuery = dbQuery.Where(o => o.FechaDeVencimiento >= date1);

            if (date2 != null && date1 == null)
                dbQuery = dbQuery.Where(o => o.FechaDeVencimiento <= date2);

            if (date2 != null && date1 != null)
                dbQuery = dbQuery.Where(o => o.FechaDeVencimiento >= date1 && o.FechaDeVencimiento <= date2);

            return dbQuery.ToList();


        }
    }
}
