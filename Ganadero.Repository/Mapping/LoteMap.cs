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
    public class LoteMap : EntityTypeConfiguration<Lote>
    {
        public LoteMap()
        {
            //key 
            this.HasKey(p => p.IdLote);

            //propiedades
            this.Property(p => p.IdLote)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.Property(p => p.NroLote)
                .IsRequired();

            this.Property(p => p.StockInicial)
                .IsRequired();

            this.Property(p => p.FechaDeVencimiento)
                .IsRequired();


            this.HasRequired(p => p.producto).
              WithMany().HasForeignKey(p => p.idProducto)
              .WillCascadeOnDelete(false);
            //

            this.HasRequired(p => p.Proveedor).
               WithMany().HasForeignKey(p => p.idProveedor)
               .WillCascadeOnDelete(false);

        }
    }
}
