using System;
using System.Collections.Generic;

namespace Ganadero.BussinesEntities
{
    public class Categoria
    {
        public Int32 IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public virtual List<Producto> producto { get; set; }

    }
}