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
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            //key 
            this.HasKey(p => p.Idusuario);

            //propiedades
            this.Property(p => p.Idusuario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Nombre)
                .HasMaxLength(30)
                .IsRequired();
            this.Property(p => p.ApellidoPaterno)
                .HasMaxLength(30)
                .IsRequired();
            this.Property(p => p.apellidoMaterno)
                .HasMaxLength(30)
                .IsRequired();
            this.Property(p => p.Direccion)
                .HasMaxLength(30)
                .IsRequired();

            this.Property(p => p.Genero)
                .HasMaxLength(1)
                .IsRequired();

            this.Property(p => p.Email)
                .HasMaxLength(60)
                .IsRequired();
            this.Property(p => p.Cuenta)
                .HasMaxLength(10)
                .IsRequired();
            this.Property(p => p.Password)
                .HasMaxLength(15)
                .IsRequired();
            this.Property(p => p.telefono)
                .HasMaxLength(9)
                .IsRequired();

            this.Property(p => p.DNI)
                    .HasMaxLength(8)
                    .IsRequired();

            //this.Property(p =>p.FechaDeIngreso)

            //    .IsRequired();


            this.Property(p => p.sueldo)

                     .IsRequired();

            this.Property(p => p.ocupacion)
                .HasMaxLength(30)
                .IsRequired();

        }
    }
}
