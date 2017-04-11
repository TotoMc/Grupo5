using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ganadero.BussinesEntities;

namespace Ganadero.BussinesEntities
{
    public class Producto
    {

        public int IdProducto { get; set; }

        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public string Marca { get; set; }

        public int IDCategoria { get; set; }
        public Categoria categoria { get; set; }
    }
}
