using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importamos.
using System.ComponentModel.DataAnnotations.Schema;
using Ganadero.BussinesEntities;
using System.Data.Entity.ModelConfiguration;

namespace Ganadero.Repository.Mapping
{
    public class entidadClienteMap :EntityTypeConfiguration<entidadCliente>
    {

        public entidadClienteMap()
        {
            this.HasKey(p => p.id);

            this.Property(p => p.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.Property(p => p.nombre).HasMaxLength(30).IsRequired();
            this.Property(p => p.dni).IsRequired();

            this.Property(p => p.Apellidos)
                .HasMaxLength(30)
                .IsRequired();

            this.Property(p => p.dni)

                .IsOptional();

            this.Property(p => p.Telefonos)
                .HasMaxLength(9)
                .IsRequired();

            this.Property(p => p.Direccion)
                .HasMaxLength(100)
                .IsRequired();
      }
    }
}
