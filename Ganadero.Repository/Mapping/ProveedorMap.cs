using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importamos
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Ganadero.BussinesEntities;

namespace Ganadero.Repository.Mapping
{
    public class ProveedorMap : EntityTypeConfiguration<Proveedor>
    {
          public ProveedorMap()
        {
            //key 
            this.HasKey(p => p.IdProveedor);

            //propiedades
            this.Property(p => p.IdProveedor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Ruc)
                .HasMaxLength(11)
                .IsRequired();

            this.Property(p => p.Nombre)
                .HasMaxLength(250)
                .IsRequired();

            this.Property(p => p.Telefono)
              .HasMaxLength(20)
              .IsRequired();

            this.Property(p => p.Ciudad)
             .HasMaxLength(250)
             .IsRequired();

            this.Property(p => p.Correo)
             .HasMaxLength(250)
             .IsRequired();

            this.Property(p => p.PaginaWeb)
                .HasMaxLength(250)
                .IsRequired();

           
        }
    }
}
