using System;

namespace Ganadero.BussinesEntities
{
    public class Lote
    {
        
        public Int32 IdLote { get; set; }

        public DateTime? FechaDeVencimiento { get; set; }
        
        public Int32 NroLote { get; set; }
        
        public Int32 StockInicial { get; set; }

        public int idProducto { get; set; }
        public Producto producto { get; set; }

        //proveedor
   
        public int idProveedor { get; set; }
        public Proveedor Proveedor{ get; set; }
    }
}