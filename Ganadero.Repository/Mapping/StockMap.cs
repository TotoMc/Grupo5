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
    public class StockMap : EntityTypeConfiguration<Stock>
    {
        public StockMap()
        {
            //key 
            this.HasKey(p => p.Idstock);

            //propiedades
            this.Property(p => p.Idstock)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.Property(p => p.Stock_Actual)
                .IsRequired();
            this.HasRequired(p => p.Lote).WithMany().HasForeignKey(p => p.IdLote).WillCascadeOnDelete(false);
            this.HasRequired(p => p.Producto).WithMany().HasForeignKey(p => p.IdProducto).WillCascadeOnDelete(false);

        }
    }
}
