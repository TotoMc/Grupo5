using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganadero.BussinesEntities
{
    public class entidadCliente
    {
        public int id { get; set; }

        public string nombre { get;set; }
         
        public int dni { get; set; }
         
        public string Direccion { get; set; }

      
          public string Apellidos { get; set; }
       
        public string Telefonos { get; set; }

        public virtual List<Venta> venta { get; set; }
    }
}
