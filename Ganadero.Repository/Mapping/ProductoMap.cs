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
    public class ProductoMap : EntityTypeConfiguration<Producto>
    {
        public ProductoMap()
        {
            //key 
            this.HasKey(p => p.IdProducto);
            this.Property(p => p.IdProducto)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //propiedades
            
                

            this.Property(p => p.NombreProducto)
                .HasMaxLength(30)
                .IsRequired();

            this.Property(p => p.Precio)
                .HasPrecision(5, 2)
                .IsRequired();

            this.Property(p => p.Marca)
                .HasMaxLength(30)
                .IsRequired();

            //this.Property(p => p.categoria)
            //    .HasMaxLength(30)
            //    .IsRequired();
            this.HasRequired(p => p.categoria)
                .WithMany().HasForeignKey(p =>
                    p.IDCategoria)
                    .WillCascadeOnDelete(false); //Relaciones


         
        }
    }
}
