using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ganadero.BussinesEntities
{
    public class Venta
    {
        public Int32 ventaID { get; set; }
        public string tipocomprobante { get; set; }
        public DateTime? fecha { get; set; }
        public double total { get; set; }
        public Boolean estado { get; set; }
        public int identiti { get; set; }
        public entidadCliente encliente { get; set; }

        public  virtual List<DetalleVenta>detalleventa { get; set; }
    }
}