namespace Ganadero.Respository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prueba1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.IdCategoria);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        NombreProducto = c.String(nullable: false, maxLength: 30),
                        Precio = c.Decimal(nullable: false, precision: 5, scale: 2),
                        Marca = c.String(nullable: false, maxLength: 30),
                        IDCategoria = c.Int(nullable: false),
                        Categoria_IdCategoria = c.Int(),
                    })
                .PrimaryKey(t => t.IdProducto)
                .ForeignKey("dbo.Categoria", t => t.IDCategoria)
                .ForeignKey("dbo.Categoria", t => t.Categoria_IdCategoria)
                .Index(t => t.IDCategoria)
                .Index(t => t.Categoria_IdCategoria);
            
            CreateTable(
                "dbo.DetalleVenta",
                c => new
                    {
                        detalleId = c.Int(nullable: false, identity: true),
                        cantidad = c.Int(nullable: false),
                        preciodeta = c.Double(nullable: false),
                        stockModificar = c.Int(nullable: false),
                        IdVentas = c.Int(nullable: false),
                        idProducto = c.Int(nullable: false),
                        Venta_ventaID = c.Int(),
                    })
                .PrimaryKey(t => t.detalleId)
                .ForeignKey("dbo.Producto", t => t.idProducto)
                .ForeignKey("dbo.Venta", t => t.Venta_ventaID)
                .ForeignKey("dbo.Venta", t => t.IdVentas)
                .Index(t => t.IdVentas)
                .Index(t => t.idProducto)
                .Index(t => t.Venta_ventaID);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        ventaID = c.Int(nullable: false, identity: true),
                        tipocomprobante = c.String(nullable: false, maxLength: 30),
                        fecha = c.DateTime(nullable: false),
                        total = c.Double(nullable: false),
                        estado = c.Boolean(nullable: false),
                        identiti = c.Int(nullable: false),
                        entidadCliente_id = c.Int(),
                    })
                .PrimaryKey(t => t.ventaID)
                .ForeignKey("dbo.entidadCliente", t => t.entidadCliente_id)
                .ForeignKey("dbo.entidadCliente", t => t.identiti)
                .Index(t => t.identiti)
                .Index(t => t.entidadCliente_id);
            
            CreateTable(
                "dbo.entidadCliente",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 30),
                        dni = c.Int(),
                        Direccion = c.String(nullable: false, maxLength: 100),
                        Apellidos = c.String(nullable: false, maxLength: 30),
                        Telefonos = c.String(nullable: false, maxLength: 9),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Lote",
                c => new
                    {
                        IdLote = c.Int(nullable: false, identity: true),
                        FechaDeVencimiento = c.DateTime(nullable: false),
                        NroLote = c.Int(nullable: false),
                        StockInicial = c.Int(nullable: false),
                        idProducto = c.Int(nullable: false),
                        idProveedor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdLote)
                .ForeignKey("dbo.Producto", t => t.idProducto)
                .ForeignKey("dbo.Proveedor", t => t.idProveedor)
                .Index(t => t.idProducto)
                .Index(t => t.idProveedor);
            
            CreateTable(
                "dbo.Proveedor",
                c => new
                    {
                        IdProveedor = c.Int(nullable: false, identity: true),
                        Ruc = c.String(nullable: false, maxLength: 11),
                        Nombre = c.String(nullable: false, maxLength: 250),
                        Telefono = c.String(nullable: false, maxLength: 20),
                        Ciudad = c.String(nullable: false, maxLength: 250),
                        Correo = c.String(nullable: false, maxLength: 250),
                        PaginaWeb = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.IdProveedor);
            
            CreateTable(
                "dbo.OrdenDeCompra",
                c => new
                    {
                        IdOrdenCompra = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 5, scale: 2),
                        IdProdcuto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOrdenCompra)
                .ForeignKey("dbo.Producto", t => t.IdProdcuto)
                .Index(t => t.IdProdcuto);
            
            CreateTable(
                "dbo.Servicio",
                c => new
                    {
                        Id_servicio = c.Int(nullable: false, identity: true),
                        Precio = c.Decimal(nullable: false, precision: 5, scale: 2),
                        NombreServicio = c.String(nullable: false, maxLength: 30),
                        Descripcion = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id_servicio);
            
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        Idstock = c.Int(nullable: false, identity: true),
                        IdProducto = c.Int(nullable: false),
                        IdLote = c.Int(nullable: false),
                        Stock_Actual = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Idstock)
                .ForeignKey("dbo.Lote", t => t.IdLote)
                .ForeignKey("dbo.Producto", t => t.IdProducto)
                .Index(t => t.IdProducto)
                .Index(t => t.IdLote);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Idusuario = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        ApellidoPaterno = c.String(nullable: false, maxLength: 30),
                        apellidoMaterno = c.String(nullable: false, maxLength: 30),
                        Direccion = c.String(nullable: false, maxLength: 30),
                        Genero = c.String(nullable: false, maxLength: 1),
                        Email = c.String(nullable: false, maxLength: 60),
                        Cuenta = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false, maxLength: 15),
                        telefono = c.String(nullable: false, maxLength: 9),
                        DNI = c.String(nullable: false, maxLength: 8),
                        sueldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ocupacion = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Idusuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stock", "IdProducto", "dbo.Producto");
            DropForeignKey("dbo.Stock", "IdLote", "dbo.Lote");
            DropForeignKey("dbo.OrdenDeCompra", "IdProdcuto", "dbo.Producto");
            DropForeignKey("dbo.Lote", "idProveedor", "dbo.Proveedor");
            DropForeignKey("dbo.Lote", "idProducto", "dbo.Producto");
            DropForeignKey("dbo.DetalleVenta", "IdVentas", "dbo.Venta");
            DropForeignKey("dbo.Venta", "identiti", "dbo.entidadCliente");
            DropForeignKey("dbo.Venta", "entidadCliente_id", "dbo.entidadCliente");
            DropForeignKey("dbo.DetalleVenta", "Venta_ventaID", "dbo.Venta");
            DropForeignKey("dbo.DetalleVenta", "idProducto", "dbo.Producto");
            DropForeignKey("dbo.Producto", "Categoria_IdCategoria", "dbo.Categoria");
            DropForeignKey("dbo.Producto", "IDCategoria", "dbo.Categoria");
            DropIndex("dbo.Stock", new[] { "IdLote" });
            DropIndex("dbo.Stock", new[] { "IdProducto" });
            DropIndex("dbo.OrdenDeCompra", new[] { "IdProdcuto" });
            DropIndex("dbo.Lote", new[] { "idProveedor" });
            DropIndex("dbo.Lote", new[] { "idProducto" });
            DropIndex("dbo.Venta", new[] { "entidadCliente_id" });
            DropIndex("dbo.Venta", new[] { "identiti" });
            DropIndex("dbo.DetalleVenta", new[] { "Venta_ventaID" });
            DropIndex("dbo.DetalleVenta", new[] { "idProducto" });
            DropIndex("dbo.DetalleVenta", new[] { "IdVentas" });
            DropIndex("dbo.Producto", new[] { "Categoria_IdCategoria" });
            DropIndex("dbo.Producto", new[] { "IDCategoria" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Stock");
            DropTable("dbo.Servicio");
            DropTable("dbo.OrdenDeCompra");
            DropTable("dbo.Proveedor");
            DropTable("dbo.Lote");
            DropTable("dbo.entidadCliente");
            DropTable("dbo.Venta");
            DropTable("dbo.DetalleVenta");
            DropTable("dbo.Producto");
            DropTable("dbo.Categoria");
        }
    }
}
