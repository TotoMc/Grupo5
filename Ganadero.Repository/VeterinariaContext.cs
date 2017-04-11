using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using Ganadero.BussinesEntities;
using Ganadero.Repository.Mapping;

namespace Ganadero.Respository
{
   public class VeterinariaContext:DbContext

    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<DetalleVenta> DetalleVenta { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<OrdenDeCompra> OrdenDeCompras { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<entidadCliente> entidadCliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new DetalleVentaMap());
            modelBuilder.Configurations.Add(new LoteMap());
            modelBuilder.Configurations.Add(new OrdenDeCompraMap());
            modelBuilder.Configurations.Add(new ProductoMap());
            modelBuilder.Configurations.Add(new ServiciosMap());
            modelBuilder.Configurations.Add(new StockMap ());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new ventaMap());
            modelBuilder.Configurations.Add(new ProveedorMap());
            modelBuilder.Configurations.Add(new entidadClienteMap());
        }
    }
}
