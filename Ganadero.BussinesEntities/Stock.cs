using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ganadero.BussinesEntities
{
    public class Stock
    {
        public Int32 Idstock { get; set; }
        public int IdProducto { get; set; }
        public Int32 IdLote { get; set; }
        public Int32 Stock_Actual { get; set; }

        public Producto Producto { get; set; }
        public Lote Lote { get; set; }
       
    }
}