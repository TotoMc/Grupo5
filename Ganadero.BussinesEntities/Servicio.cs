using System;

namespace Ganadero.BussinesEntities
{
    public class Servicio
    {
        
        public Int32 Id_servicio { get; set; }
        public decimal Precio { get; set; }
        
        public string NombreServicio { get; set; }
       
        public string Descripcion { get; set; }
        
    }
}