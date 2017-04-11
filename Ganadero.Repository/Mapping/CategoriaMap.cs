using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//importamos.
using System.ComponentModel.DataAnnotations.Schema;
using Ganadero.BussinesEntities;
using System.Data.Entity.ModelConfiguration;

namespace Ganadero.Repository.Mapping
{
    public class CategoriaMap:EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            //key 
            this.HasKey(p => p.IdCategoria);

            //propiedades
            this.Property(p => p.IdCategoria)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Descripcion)
                .HasMaxLength(30)
                .IsRequired();
           

        }
    }
}
