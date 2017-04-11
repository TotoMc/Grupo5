using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ganadero.BussinesEntities
{
    public class OrdenDeCompra
    {
        public Int32 IdOrdenCompra { get; set; }
        public Int32 Cantidad { get; set; }

        public decimal Precio { get; set; }

        //----------------------------

     
        public int IdProdcuto { get; set; }
        public Producto Producto { get; set; }
    }
}