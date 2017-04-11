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
    public class OrdenDeCompraMap : EntityTypeConfiguration<OrdenDeCompra>
    {
        public OrdenDeCompraMap()
        {
            //key 
            this.HasKey(p => p.IdOrdenCompra);

            //propiedades
            this.Property(p => p.IdOrdenCompra)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Cantidad)
                .IsRequired();

            this.Property(p => p.Precio)
                .HasPrecision(5, 2)
                .IsRequired();

            this.HasRequired(p => p.Producto).
                WithMany().HasForeignKey(p => p.IdProdcuto)
                .WillCascadeOnDelete(false);
        }
    }
}
