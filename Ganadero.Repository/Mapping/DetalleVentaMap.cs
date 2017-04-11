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
    public class DetalleVentaMap:EntityTypeConfiguration<DetalleVenta>
    {

        public DetalleVentaMap() {

            //key 
            this.HasKey(p => p.detalleId);

            //propiedades
            this.Property(p => p.detalleId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.cantidad)
                .IsRequired();
            this.Property(p => p.preciodeta)
             .IsRequired();

            this.Property(p => p.stockModificar)
            .IsRequired();


            this.HasRequired(p => p.venta).
              WithMany().HasForeignKey(p => p.IdVentas)
              .WillCascadeOnDelete(false);

            this.HasRequired(p => p.producto).
            WithMany().HasForeignKey(p => p.idProducto)
            .WillCascadeOnDelete(false);


        
        
        
        
        }
    }
}
