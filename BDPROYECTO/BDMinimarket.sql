USE [AbarrotesSist]
GO
/****** Object:  Table [dbo].[Capital]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Capital](
	[CapitalID] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [nvarchar](50) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Capital] PRIMARY KEY CLUSTERED 
(
	[CapitalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[CategoriaID] [int] IDENTITY(1,1) NOT NULL,
	[NombreCategoria] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[CategoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cierrecaja]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cierrecaja](
	[CierrecajaID] [int] IDENTITY(1,1) NOT NULL,
	[CapitalID] [int] NOT NULL,
	[GananciaTotal] [real] NULL,
	[TotalEgreso] [real] NULL,
	[TotalIngreso] [real] NULL,
 CONSTRAINT [PK_Cierrecaja] PRIMARY KEY CLUSTERED 
(
	[CierrecajaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[CiudadID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[CiudadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [varchar](50) NULL,
	[MetodopagoID] [int] NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Direccion] [nvarchar](max) NULL,
	[Telefono] [nvarchar](max) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalleordencompra]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalleordencompra](
	[DetalleordencompraID] [int] IDENTITY(1,1) NOT NULL,
	[OrdencompraID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[NombreProducto] [nvarchar](50) NULL,
	[Categoria] [nvarchar](50) NULL,
	[CostoUnitario] [real] NULL,
	[CantidadRequerida] [int] NULL,
 CONSTRAINT [PK_Detalleordencompra] PRIMARY KEY CLUSTERED 
(
	[DetalleordencompraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detallepedido]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detallepedido](
	[DetallepedidoID] [int] IDENTITY(1,1) NOT NULL,
	[VentaID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[DescProducto] [nvarchar](50) NULL,
	[Categoria] [nvarchar](50) NULL,
	[PrecioUnitario] [real] NULL,
	[Cantidad] [int] NULL,
	[Subtotal] [real] NULL,
 CONSTRAINT [PK_Detallepedido] PRIMARY KEY CLUSTERED 
(
	[DetallepedidoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetPedido]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetPedido](
	[DetallepedidoID] [int] IDENTITY(1,1) NOT NULL,
	[VentaID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[PrecioUnitario] [real] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_DetPedido] PRIMARY KEY CLUSTERED 
(
	[DetallepedidoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fondos]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fondos](
	[FondosID] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [money] NULL,
	[Fecha] [date] NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Fondos] PRIMARY KEY CLUSTERED 
(
	[FondosID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formapago]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formapago](
	[FormapagoID] [int] IDENTITY(1,1) NOT NULL,
	[MetodoPago] [nvarchar](50) NULL,
 CONSTRAINT [PK_Formapago] PRIMARY KEY CLUSTERED 
(
	[FormapagoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Metodopago]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodopago](
	[MetodopagoID] [int] IDENTITY(1,1) NOT NULL,
	[FormaPago] [nvarchar](50) NULL,
 CONSTRAINT [PK_Metodopago] PRIMARY KEY CLUSTERED 
(
	[MetodopagoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordencompra]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordencompra](
	[OrdencompraID] [int] IDENTITY(1,1) NOT NULL,
	[FormapagoID] [int] NOT NULL,
	[ProveedorID] [int] NOT NULL,
	[RequerimientoID] [int] NOT NULL,
	[Categoria] [nvarchar](50) NULL,
	[CostoTotal] [real] NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_Ordencompra] PRIMARY KEY CLUSTERED 
(
	[OrdencompraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[VentaID] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NOT NULL,
	[fechaVenta] [date] NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[VentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProductoID] [int] IDENTITY(1,1) NOT NULL,
	[CategoriaID] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Stock] [nvarchar](50) NULL,
	[FechaVencimiento] [date] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ProductosID] [int] IDENTITY(1,1) NOT NULL,
	[CategoriaID] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Stock] [nvarchar](50) NULL,
	[Precio] [int] NULL,
	[FechaVencimiento] [date] NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ProductosID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ProveedorID] [int] IDENTITY(1,1) NOT NULL,
	[CiudadID] [int] NOT NULL,
	[Ruc] [nvarchar](50) NULL,
	[Nombre] [nvarchar](50) NULL,
	[RazSocial] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[ProveedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requerimiento]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requerimiento](
	[RequerimientoID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoID] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Cantidad] [int] NULL,
	[PrecioUnitario] [int] NULL,
	[SubTotal] [real] NULL,
 CONSTRAINT [PK_Requerimiento] PRIMARY KEY CLUSTERED 
(
	[RequerimientoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[VentaID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NOT NULL,
	[CierrecajaID] [int] NOT NULL,
	[NombreProducto] [nvarchar](50) NULL,
	[Categoria] [nvarchar](50) NULL,
	[PrecioUnitario] [nvarchar](50) NULL,
	[Cantidad] [int] NULL,
	[Stock] [int] NULL,
	[FechaVencimiento] [date] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[VentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cierrecaja]  WITH CHECK ADD  CONSTRAINT [FK_Cierrecaja_Capital] FOREIGN KEY([CapitalID])
REFERENCES [dbo].[Capital] ([CapitalID])
GO
ALTER TABLE [dbo].[Cierrecaja] CHECK CONSTRAINT [FK_Cierrecaja_Capital]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Metodopago] FOREIGN KEY([MetodopagoID])
REFERENCES [dbo].[Metodopago] ([MetodopagoID])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Metodopago]
GO
ALTER TABLE [dbo].[Detalleordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Detalleordencompra_Ordencompra] FOREIGN KEY([OrdencompraID])
REFERENCES [dbo].[Ordencompra] ([OrdencompraID])
GO
ALTER TABLE [dbo].[Detalleordencompra] CHECK CONSTRAINT [FK_Detalleordencompra_Ordencompra]
GO
ALTER TABLE [dbo].[Detalleordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Detalleordencompra_Producto] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([ProductoID])
GO
ALTER TABLE [dbo].[Detalleordencompra] CHECK CONSTRAINT [FK_Detalleordencompra_Producto]
GO
ALTER TABLE [dbo].[Detallepedido]  WITH CHECK ADD  CONSTRAINT [FK_Detallepedido_Producto] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([ProductoID])
GO
ALTER TABLE [dbo].[Detallepedido] CHECK CONSTRAINT [FK_Detallepedido_Producto]
GO
ALTER TABLE [dbo].[Detallepedido]  WITH CHECK ADD  CONSTRAINT [FK_Detallepedido_Venta] FOREIGN KEY([VentaID])
REFERENCES [dbo].[Venta] ([VentaID])
GO
ALTER TABLE [dbo].[Detallepedido] CHECK CONSTRAINT [FK_Detallepedido_Venta]
GO
ALTER TABLE [dbo].[Ordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Ordencompra_Formapago] FOREIGN KEY([FormapagoID])
REFERENCES [dbo].[Formapago] ([FormapagoID])
GO
ALTER TABLE [dbo].[Ordencompra] CHECK CONSTRAINT [FK_Ordencompra_Formapago]
GO
ALTER TABLE [dbo].[Ordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Ordencompra_Proveedor] FOREIGN KEY([ProveedorID])
REFERENCES [dbo].[Proveedor] ([ProveedorID])
GO
ALTER TABLE [dbo].[Ordencompra] CHECK CONSTRAINT [FK_Ordencompra_Proveedor]
GO
ALTER TABLE [dbo].[Ordencompra]  WITH CHECK ADD  CONSTRAINT [FK_Ordencompra_Requerimiento] FOREIGN KEY([RequerimientoID])
REFERENCES [dbo].[Requerimiento] ([RequerimientoID])
GO
ALTER TABLE [dbo].[Ordencompra] CHECK CONSTRAINT [FK_Ordencompra_Requerimiento]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([CategoriaID])
REFERENCES [dbo].[Categoria] ([CategoriaID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Ciudad] FOREIGN KEY([CiudadID])
REFERENCES [dbo].[Ciudad] ([CiudadID])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Ciudad]
GO
ALTER TABLE [dbo].[Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_Requerimiento_Producto] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([ProductoID])
GO
ALTER TABLE [dbo].[Requerimiento] CHECK CONSTRAINT [FK_Requerimiento_Producto]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cierrecaja] FOREIGN KEY([CierrecajaID])
REFERENCES [dbo].[Cierrecaja] ([CierrecajaID])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cierrecaja]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Cliente] ([ClienteID])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
/****** Object:  StoredProcedure [dbo].[spBuscarCliente]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spBuscarCliente]
 ( @prmIdCliente varchar(50)
 )
 as
 Begin
  Select ClienteID,DNI,Nombre, Direccion, Telefono,Estado from Cliente
  where ClienteID = @prmIdCliente
 end

 drop table Venta
 CREATE TABLE [Venta]
(
	[VentaID] int NOT NULL IDENTITY (1, 1),
	[ClienteID] int NOT NULL,
	[fechaVenta] Date NOT NULL,
	Total DECIMAL(18,2) NOT NULL,

PRIMARY KEY CLUSTERED 
(
	[VentaID] ASC
))
GO
/****** Object:  StoredProcedure [dbo].[spBuscarProducto]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spBuscarProducto]
 ( @ProductosID int
 )
 as
 Begin
  Select ProductoID,Nombre, Stock, FechaVencimiento from Producto
  where ProductoID = @ProductosID
 end
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitaCapital]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Eliminar
CREATE PROCEDURE [dbo].[spDeshabilitaCapital]
(@FondosID INT)
AS
BEGIN
    UPDATE Fondos
	SET Estado = 0
    WHERE FondosID = @FondosID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitaCategoria]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Eliminar
CREATE PROCEDURE [dbo].[spDeshabilitaCategoria]
(@CategoriaID INT)
AS
BEGIN
    UPDATE Categoria 
    SET Estado = 0	
    WHERE CategoriaID = @CategoriaID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitaCliente]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Eliminar
CREATE PROCEDURE [dbo].[spDeshabilitaCliente]
(@ClienteID INT)
AS
BEGIN
    UPDATE Cliente 
    SET Estado = 0	
    WHERE ClienteID = @ClienteID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitaProducto]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Eliminar
CREATE PROCEDURE [dbo].[spDeshabilitaProducto]
(@ProductosID INT)
AS
BEGIN
    UPDATE Productos 
    SET Estado = 0	
    WHERE ProductosID = @ProductosID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitaProveedor]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Eliminar
CREATE PROCEDURE [dbo].[spDeshabilitaProveedor]
(@ProveedorID INT)
AS
BEGIN
    UPDATE Proveedor 
    SET Estado = 0	
    WHERE ProveedorID = @ProveedorID
END
GO
/****** Object:  StoredProcedure [dbo].[spEditaCapital]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEditaCapital]
(@FondosID INT,
 @Monto MONEY,
 @Fecha date,
 @Estado BIT)
AS
BEGIN
    UPDATE Fondos 
    SET Monto = @Monto , Fecha = @Fecha, Estado = @Estado
    WHERE FondosID = @FondosID
END
GO
/****** Object:  StoredProcedure [dbo].[spEditaCategoria]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEditaCategoria]
(@CategoriaID INT,
 @NombreCategoria NVARCHAR(100),
 @Descripcion NVARCHAR(100))
 
AS
BEGIN
    UPDATE Categoria 
    SET NombreCategoria = @NombreCategoria, Descripcion = @Descripcion
    WHERE CategoriaID = @CategoriaID
END
GO
/****** Object:  StoredProcedure [dbo].[spEditaCliente]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEditaCliente]
(@ClienteID INT,
 @DNI NVARCHAR(100),
 @MetodoPagoID INT,
 @Nombre NVARCHAR(50),
 @Direccion NVARCHAR(50),
 @Telefono NVARCHAR(20),
 @Estado BIT)
AS
BEGIN
    UPDATE Cliente
    SET DNI = @DNI, MetodoPagoID = @MetodoPagoID, Nombre = @Nombre, Direccion = @Direccion,Telefono=@Telefono, Estado = @Estado 
    WHERE ClienteID = @ClienteID
END

GO
/****** Object:  StoredProcedure [dbo].[spEditaProductos]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Editar
CREATE PROCEDURE [dbo].[spEditaProductos]
(@ProductosID INT,
 @CategoriaID INT,
 @Nombre NVARCHAR(100),
 @Descripcion NVARCHAR(20),
 @Stock INT,
 @Precio INT,
 @FechaVencimiento date,
 @Estado BIT)
AS
BEGIN
    UPDATE Productos
    SET CategoriaID = @CategoriaID,Nombre = @Nombre, Descripcion = @Descripcion, Stock = @Stock,Precio = @Precio, FechaVencimiento = @FechaVencimiento, Estado = @Estado 
    WHERE @ProductosID = @ProductosID
END
GO
/****** Object:  StoredProcedure [dbo].[spEditaProveedor]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEditaProveedor]
(@ProveedorID INT,
 @CiudadID INT,
 @Ruc NVARCHAR(100),
 @Nombre NVARCHAR(100),
 @RazSocial NVARCHAR(100),
 @Telefono NVARCHAR(20),
 @Direccion NVARCHAR(200),
 @Estado BIT)
AS
BEGIN
    UPDATE Proveedor 
    SET CiudadID = @CiudadID,Ruc= @Ruc, Nombre=@Nombre, RazSocial = @RazSocial, Telefono = @Telefono, Direccion = @Direccion, Estado = @Estado 
    WHERE @ProveedorID = @ProveedorID
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertaCapital]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertaCapital]
(@Monto money,
 @Estado bit,
 @Fecha date
 )
AS
BEGIN
    INSERT INTO Fondos (Monto,Estado,Fecha) 
    VALUES (@Monto, @Estado,@Fecha)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertaCategoria]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertaCategoria]
(@NombreCategoria NVARCHAR(100),
 @Descripcion NVARCHAR(100),
 @Estado BIT)

AS
BEGIN
    INSERT INTO Categoria (NombreCategoria, Descripcion, Estado) 
    VALUES (@NombreCategoria, @Descripcion, @Estado)
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertaCliente]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertaCliente]
(@DNI NVARCHAR(50),
 @MetodopagoID Int,
 @Nombre NVARCHAR (50),
 @Direccion NVARCHAR(200),
 @Telefono NVARCHAR(20),
 @Estado BIT)
AS
BEGIN
    INSERT INTO Cliente (DNI, MetodopagoID,Nombre , Direccion,Telefono, Estado) 
    VALUES (@DNI, @MetodopagoID, @Nombre,@Telefono,@Direccion, @Estado)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertaProducto]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertaProducto]
(@CategoriaID INT,
 @Nombre NVARCHAR(100),
 @Descripcion NVARCHAR(20),
 @Stock NVARCHAR(200),
 @Precio INT,
 @FechaVencimiento date,
 @Estado BIT)
AS
BEGIN
    INSERT INTO Productos (CategoriaID, Nombre, Descripcion, Stock,Precio,FechaVencimiento, Estado) 
    VALUES (@CategoriaID, @Nombre, @Descripcion, @Stock,@Precio,@FechaVencimiento,@Estado)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertaProveedor]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Insertar
CREATE PROCEDURE [dbo].[spInsertaProveedor]
(@CiudadID INT,
 @Ruc NVARCHAR(100),
 @Nombre NVARCHAR(100),
 @RazSocial NVARCHAR(100),
 @Telefono NVARCHAR(20),
 @Direccion NVARCHAR(200),
 @Estado BIT)
AS
BEGIN
    INSERT INTO Proveedor (CiudadID,Ruc,Nombre, RazSocial, Telefono, Direccion, Estado) 
    VALUES (@CiudadID,@Ruc,@Nombre, @RazSocial, @Telefono, @Direccion, @Estado)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertarDetPedido]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spInsertarDetPedido]
(@idProducto Int,
@idPedido Int,
@cantProducto Int,
@precProducto Decimal(6,2)
--@igv Decimal(6,2)
--@Mensaje Varchar(100) Out

)
As Begin          
	Declare @Stock As Int
	Set @Stock=(Select Stock From Producto Where ProductoID=@idProducto)
	
		Insert into DetPedido Values (@idProducto,@idPedido,@cantProducto,@PrecProducto)
		
	 
		Update Producto Set Stock=@Stock-@cantProducto Where ProductoID=@IdProducto
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertarVenta]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[spInsertarVenta]
@idCliente Int,
@fechPedido Date,
@TotPedido decimal(8,2)
--@Mensaje Varchar(100) Out
As 
	Declare @idPedido int

Insert Pedido Values(@idCliente,@fechPedido, @TotPedido)

		SET @idPedido = @@IDENTITY

    return @idPedido
GO
/****** Object:  StoredProcedure [dbo].[spListaCapital]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spListaCapital]
AS
SELECT FondosID, Monto, Estado, Fecha
FROM Fondos
GO
/****** Object:  StoredProcedure [dbo].[spListaCategoria]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListaCategoria]
AS
SELECT CategoriaID, NombreCategoria, Descripcion, Estado
FROM Categoria
WHERE Estado = 1;
GO
/****** Object:  StoredProcedure [dbo].[spListaCliente]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListaCliente]
AS
SELECT ClienteID, DNI, MetodopagoID,Nombre, Direccion, Telefono, Estado
FROM Cliente
WHERE Estado = 1;
GO
/****** Object:  StoredProcedure [dbo].[spListaProductos]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListaProductos]
AS
SELECT ProductosID, CategoriaID, Nombre, Descripcion, Stock,Precio, FechaVencimiento, Estado
FROM Productos
WHERE Estado = 1;
GO
/****** Object:  StoredProcedure [dbo].[spListaProveedor]    Script Date: 23/11/2023 01:57:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListaProveedor]
AS
SELECT ProveedorID, CiudadID,Ruc,Nombre, RazSocial, Telefono, Direccion, Estado
FROM Proveedor
WHERE Estado = 1;
GO
