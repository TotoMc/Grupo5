using System;

namespace Ganadero.BussinesEntities
{
    public class DetalleVenta
    {
         public Int32 detalleId { get; set;}
          
         public int cantidad { get; set; }
           
         public double preciodeta { get; set; }

        public Int32 stockModificar { get; set; }

        // venta
        public Int32 IdVentas { get; set; }
        public virtual Venta venta { get; set; }
         //producto
         public Int32 idProducto { get; set; }
        public  virtual Producto producto { get; set; }
         // atributos  detalle vent


      
    }
}
