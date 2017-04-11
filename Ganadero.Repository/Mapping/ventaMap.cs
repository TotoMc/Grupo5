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
    public class ventaMap: EntityTypeConfiguration<Venta>
    {
        public ventaMap()
        {
            //key 
            this.HasKey(p => p.ventaID);

            //propiedades
            this.Property(p => p.ventaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.fecha)
                .IsRequired();
            this.Property(p => p.tipocomprobante)
                .HasMaxLength(30)
             .IsRequired();

            this.Property(p => p.estado);

         
            this.Property(p => p.total)
               
               .IsRequired();


            this.HasRequired(p => p.encliente).
            WithMany().HasForeignKey(p => p.identiti)
            .WillCascadeOnDelete(false);
        }
    }
}
