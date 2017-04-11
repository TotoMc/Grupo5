using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Ganadero.BussinesEntities
{
    public class Usuario
    {
        public Int32 Idusuario { get; set; }
        public string Nombre { get; set; }
    
        public string ApellidoPaterno { get; set; }

        public string apellidoMaterno { get; set; }

        public string Direccion { get; set; }

        public string Genero { get; set; }
 
        public string Email { get; set; }

        public string Cuenta { get; set; }

        public string Password { get; set; }
  
        public string telefono { get; set; }

        public string DNI { get; set; }
        //public DateTime FechaDeIngreso { get; set; }
        public decimal sueldo { get; set; }
        public string ocupacion { get; set; }
        
    }
}