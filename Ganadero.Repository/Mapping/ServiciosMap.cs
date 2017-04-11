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
    public class ServiciosMap : EntityTypeConfiguration<Servicio>
    {
         public ServiciosMap()
        {
            //key 
            this.HasKey(p => p.Id_servicio);

            //propiedades
            this.Property(p => p.Id_servicio)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.NombreServicio)
                .HasMaxLength(30)
                .IsRequired();

            this.Property(p => p.Precio)
                .HasPrecision(5,2)
                .IsRequired();

            this.Property(p => p.Descripcion)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
