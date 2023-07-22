
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/22/2023 11:41:13
-- Generated from EDMX file: C:\Users\FRANCISCO\source\repos\Proyecto_DB\proyecto_Db_EDM\ModelDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProyectoDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BodegaArticuloProveedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proveedor] DROP CONSTRAINT [FK_BodegaArticuloProveedor];
GO
IF OBJECT_ID(N'[dbo].[FK_ArticulosBodegaArticulo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BodegaArticulo] DROP CONSTRAINT [FK_ArticulosBodegaArticulo];
GO
IF OBJECT_ID(N'[dbo].[FK_ArticulosUnidadMedidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articulos] DROP CONSTRAINT [FK_ArticulosUnidadMedidad];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaArticulos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articulos] DROP CONSTRAINT [FK_CategoriaArticulos];
GO
IF OBJECT_ID(N'[dbo].[FK_PresentacionArticulos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articulos] DROP CONSTRAINT [FK_PresentacionArticulos];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientesFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Factura] DROP CONSTRAINT [FK_ClientesFactura];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpleadosFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Factura] DROP CONSTRAINT [FK_EmpleadosFactura];
GO
IF OBJECT_ID(N'[dbo].[FK_CargoEmpleados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_CargoEmpleados];
GO
IF OBJECT_ID(N'[dbo].[FK_ArticulosFacturaLineas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FacturaLineas] DROP CONSTRAINT [FK_ArticulosFacturaLineas];
GO
IF OBJECT_ID(N'[dbo].[FK_FacturaFacturaLineas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FacturaLineas] DROP CONSTRAINT [FK_FacturaFacturaLineas];
GO
IF OBJECT_ID(N'[dbo].[FK_FormaPagoFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Factura] DROP CONSTRAINT [FK_FormaPagoFactura];
GO
IF OBJECT_ID(N'[dbo].[FK_BodegaBodegaArticulo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BodegaArticulo] DROP CONSTRAINT [FK_BodegaBodegaArticulo];
GO
IF OBJECT_ID(N'[dbo].[FK_FacturaRecibo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Recibo] DROP CONSTRAINT [FK_FacturaRecibo];
GO
IF OBJECT_ID(N'[dbo].[FK_MinicipioClientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clientes] DROP CONSTRAINT [FK_MinicipioClientes];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartamentoMinicipio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Minicipio] DROP CONSTRAINT [FK_DepartamentoMinicipio];
GO
IF OBJECT_ID(N'[dbo].[FK_SexoEmpleados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_SexoEmpleados];
GO
IF OBJECT_ID(N'[dbo].[FK_SexoClientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clientes] DROP CONSTRAINT [FK_SexoClientes];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Articulos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Articulos];
GO
IF OBJECT_ID(N'[dbo].[UnidadMedidad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UnidadMedidad];
GO
IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Categoria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categoria];
GO
IF OBJECT_ID(N'[dbo].[Presentacion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Presentacion];
GO
IF OBJECT_ID(N'[dbo].[Factura]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Factura];
GO
IF OBJECT_ID(N'[dbo].[Empleados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados];
GO
IF OBJECT_ID(N'[dbo].[BodegaArticulo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BodegaArticulo];
GO
IF OBJECT_ID(N'[dbo].[Proveedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proveedor];
GO
IF OBJECT_ID(N'[dbo].[Cargo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cargo];
GO
IF OBJECT_ID(N'[dbo].[FacturaLineas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FacturaLineas];
GO
IF OBJECT_ID(N'[dbo].[FormaPago]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormaPago];
GO
IF OBJECT_ID(N'[dbo].[Bodega]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bodega];
GO
IF OBJECT_ID(N'[dbo].[Minicipio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Minicipio];
GO
IF OBJECT_ID(N'[dbo].[Departamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departamento];
GO
IF OBJECT_ID(N'[dbo].[Recibo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Recibo];
GO
IF OBJECT_ID(N'[dbo].[Sexo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sexo];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Articulos'
CREATE TABLE [dbo].[Articulos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Precio] float  NOT NULL,
    [Medida] nvarchar(max)  NOT NULL,
    [Estado] int  NOT NULL,
    [UsuarioCreacion] nvarchar(max)  NOT NULL,
    [FechaCreacion] datetime  NOT NULL,
    [UsuarioModificacion] nvarchar(max)  NULL,
    [FechaModificacion] datetime  NULL,
    [CategoriaId] int  NOT NULL,
    [PresentacionId] int  NOT NULL,
    [UnidadMedidad_Id] int  NOT NULL
);
GO

-- Creating table 'UnidadMedidad'
CREATE TABLE [dbo].[UnidadMedidad] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Medida] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Nombres] nvarchar(max)  NOT NULL,
    [Apellidos] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Cedula] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Estado] int  NOT NULL,
    [UsuarioCreacion] nvarchar(max)  NOT NULL,
    [FechaCreacion] datetime  NOT NULL,
    [UsuarioModificaion] nvarchar(max)  NULL,
    [FechaModificacion] datetime  NULL,
    [MinicipioId] int  NOT NULL,
    [DepartamentoId] int  NOT NULL,
    [SexoId] int  NOT NULL
);
GO

-- Creating table 'Categoria'
CREATE TABLE [dbo].[Categoria] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Presentacion'
CREATE TABLE [dbo].[Presentacion] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Factura'
CREATE TABLE [dbo].[Factura] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NoFactura] nvarchar(max)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [FechaVencimiento] datetime  NOT NULL,
    [Estado] int  NOT NULL,
    [IVA] decimal(18,0)  NOT NULL,
    [Descuento] decimal(18,0)  NOT NULL,
    [SubTotal] decimal(18,0)  NOT NULL,
    [Total] decimal(18,0)  NOT NULL,
    [Saldo] decimal(18,0)  NOT NULL,
    [UsuarioCreacion] nvarchar(max)  NOT NULL,
    [FechaCreacion] datetime  NOT NULL,
    [UsuarioModificacion] nvarchar(max)  NULL,
    [FechaModificacion] datetime  NULL,
    [ClientesId] int  NOT NULL,
    [EmpleadosId] int  NOT NULL,
    [FormaPagoId] int  NOT NULL
);
GO

-- Creating table 'Empleados'
CREATE TABLE [dbo].[Empleados] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Nombres] nvarchar(max)  NOT NULL,
    [Apellidos] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Cedula] nvarchar(max)  NOT NULL,
    [FechaNacimiento] datetime  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [INSS] nvarchar(max)  NOT NULL,
    [Salario] float  NOT NULL,
    [FechaIngreso] datetime  NOT NULL,
    [FechaAlta] datetime  NULL,
    [FechaBaja] datetime  NULL,
    [UsuarioCreacion] nvarchar(max)  NOT NULL,
    [FechaCreacion] datetime  NOT NULL,
    [UsuarioModificacion] nvarchar(max)  NULL,
    [FechaModificacion] datetime  NULL,
    [CargoId] int  NOT NULL,
    [SexoId] int  NOT NULL
);
GO

-- Creating table 'BodegaArticulo'
CREATE TABLE [dbo].[BodegaArticulo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Costo] decimal(18,0)  NOT NULL,
    [Existencia] int  NOT NULL,
    [FechaCreacion] nvarchar(max)  NOT NULL,
    [UsuarioCreacion] nvarchar(max)  NOT NULL,
    [FechaModificacion] datetime  NULL,
    [UsuarioModificacion] nvarchar(max)  NULL,
    [ArticulosId] int  NOT NULL,
    [BodegaId] int  NOT NULL
);
GO

-- Creating table 'Proveedor'
CREATE TABLE [dbo].[Proveedor] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Contacto] nvarchar(max)  NOT NULL,
    [Cargo] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [UsuarioCreacion] nvarchar(max)  NOT NULL,
    [FechaCreacion] datetime  NOT NULL,
    [UsuarioModificacion] nvarchar(max)  NULL,
    [FechaModificacion] datetime  NULL,
    [BodegaArticuloId] int  NOT NULL
);
GO

-- Creating table 'Cargo'
CREATE TABLE [dbo].[Cargo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FacturaLineas'
CREATE TABLE [dbo].[FacturaLineas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cantidad] int  NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [Total] decimal(18,0)  NOT NULL,
    [Costo] decimal(18,0)  NOT NULL,
    [ArticulosId] int  NOT NULL,
    [FacturaId] int  NOT NULL
);
GO

-- Creating table 'FormaPago'
CREATE TABLE [dbo].[FormaPago] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Dias] int  NOT NULL
);
GO

-- Creating table 'Bodega'
CREATE TABLE [dbo].[Bodega] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Activo] tinyint  NOT NULL,
    [UsuarioCreacion] nvarchar(max)  NOT NULL,
    [FechaUsuario] datetime  NOT NULL,
    [UsuarioModificacion] nvarchar(max)  NULL,
    [FechaModificacion] datetime  NULL
);
GO

-- Creating table 'Minicipio'
CREATE TABLE [dbo].[Minicipio] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [DepartamentoId] int  NOT NULL
);
GO

-- Creating table 'Departamento'
CREATE TABLE [dbo].[Departamento] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Recibo'
CREATE TABLE [dbo].[Recibo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Norecibo] nvarchar(max)  NOT NULL,
    [FechaRecibo] datetime  NOT NULL,
    [Efectivo] decimal(18,0)  NOT NULL,
    [Cheque] decimal(18,0)  NOT NULL,
    [Deposito] decimal(18,0)  NOT NULL,
    [Total] decimal(18,0)  NOT NULL,
    [MontoIR] decimal(18,0)  NOT NULL,
    [NoIR] nvarchar(max)  NOT NULL,
    [MontoIMI] decimal(18,0)  NOT NULL,
    [NoIMI] nvarchar(max)  NOT NULL,
    [Saldo] decimal(18,0)  NOT NULL,
    [Estado] int  NOT NULL,
    [FacturaId] int  NOT NULL
);
GO

-- Creating table 'Sexo'
CREATE TABLE [dbo].[Sexo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [PK_Articulos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UnidadMedidad'
ALTER TABLE [dbo].[UnidadMedidad]
ADD CONSTRAINT [PK_UnidadMedidad]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categoria'
ALTER TABLE [dbo].[Categoria]
ADD CONSTRAINT [PK_Categoria]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Presentacion'
ALTER TABLE [dbo].[Presentacion]
ADD CONSTRAINT [PK_Presentacion]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Factura'
ALTER TABLE [dbo].[Factura]
ADD CONSTRAINT [PK_Factura]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [PK_Empleados]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BodegaArticulo'
ALTER TABLE [dbo].[BodegaArticulo]
ADD CONSTRAINT [PK_BodegaArticulo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Proveedor'
ALTER TABLE [dbo].[Proveedor]
ADD CONSTRAINT [PK_Proveedor]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cargo'
ALTER TABLE [dbo].[Cargo]
ADD CONSTRAINT [PK_Cargo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FacturaLineas'
ALTER TABLE [dbo].[FacturaLineas]
ADD CONSTRAINT [PK_FacturaLineas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormaPago'
ALTER TABLE [dbo].[FormaPago]
ADD CONSTRAINT [PK_FormaPago]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bodega'
ALTER TABLE [dbo].[Bodega]
ADD CONSTRAINT [PK_Bodega]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Minicipio'
ALTER TABLE [dbo].[Minicipio]
ADD CONSTRAINT [PK_Minicipio]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Departamento'
ALTER TABLE [dbo].[Departamento]
ADD CONSTRAINT [PK_Departamento]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Recibo'
ALTER TABLE [dbo].[Recibo]
ADD CONSTRAINT [PK_Recibo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sexo'
ALTER TABLE [dbo].[Sexo]
ADD CONSTRAINT [PK_Sexo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BodegaArticuloId] in table 'Proveedor'
ALTER TABLE [dbo].[Proveedor]
ADD CONSTRAINT [FK_BodegaArticuloProveedor]
    FOREIGN KEY ([BodegaArticuloId])
    REFERENCES [dbo].[BodegaArticulo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BodegaArticuloProveedor'
CREATE INDEX [IX_FK_BodegaArticuloProveedor]
ON [dbo].[Proveedor]
    ([BodegaArticuloId]);
GO

-- Creating foreign key on [ArticulosId] in table 'BodegaArticulo'
ALTER TABLE [dbo].[BodegaArticulo]
ADD CONSTRAINT [FK_ArticulosBodegaArticulo]
    FOREIGN KEY ([ArticulosId])
    REFERENCES [dbo].[Articulos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticulosBodegaArticulo'
CREATE INDEX [IX_FK_ArticulosBodegaArticulo]
ON [dbo].[BodegaArticulo]
    ([ArticulosId]);
GO

-- Creating foreign key on [UnidadMedidad_Id] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [FK_ArticulosUnidadMedidad]
    FOREIGN KEY ([UnidadMedidad_Id])
    REFERENCES [dbo].[UnidadMedidad]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticulosUnidadMedidad'
CREATE INDEX [IX_FK_ArticulosUnidadMedidad]
ON [dbo].[Articulos]
    ([UnidadMedidad_Id]);
GO

-- Creating foreign key on [CategoriaId] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [FK_CategoriaArticulos]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categoria]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaArticulos'
CREATE INDEX [IX_FK_CategoriaArticulos]
ON [dbo].[Articulos]
    ([CategoriaId]);
GO

-- Creating foreign key on [PresentacionId] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [FK_PresentacionArticulos]
    FOREIGN KEY ([PresentacionId])
    REFERENCES [dbo].[Presentacion]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PresentacionArticulos'
CREATE INDEX [IX_FK_PresentacionArticulos]
ON [dbo].[Articulos]
    ([PresentacionId]);
GO

-- Creating foreign key on [ClientesId] in table 'Factura'
ALTER TABLE [dbo].[Factura]
ADD CONSTRAINT [FK_ClientesFactura]
    FOREIGN KEY ([ClientesId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientesFactura'
CREATE INDEX [IX_FK_ClientesFactura]
ON [dbo].[Factura]
    ([ClientesId]);
GO

-- Creating foreign key on [EmpleadosId] in table 'Factura'
ALTER TABLE [dbo].[Factura]
ADD CONSTRAINT [FK_EmpleadosFactura]
    FOREIGN KEY ([EmpleadosId])
    REFERENCES [dbo].[Empleados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadosFactura'
CREATE INDEX [IX_FK_EmpleadosFactura]
ON [dbo].[Factura]
    ([EmpleadosId]);
GO

-- Creating foreign key on [CargoId] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_CargoEmpleados]
    FOREIGN KEY ([CargoId])
    REFERENCES [dbo].[Cargo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CargoEmpleados'
CREATE INDEX [IX_FK_CargoEmpleados]
ON [dbo].[Empleados]
    ([CargoId]);
GO

-- Creating foreign key on [ArticulosId] in table 'FacturaLineas'
ALTER TABLE [dbo].[FacturaLineas]
ADD CONSTRAINT [FK_ArticulosFacturaLineas]
    FOREIGN KEY ([ArticulosId])
    REFERENCES [dbo].[Articulos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticulosFacturaLineas'
CREATE INDEX [IX_FK_ArticulosFacturaLineas]
ON [dbo].[FacturaLineas]
    ([ArticulosId]);
GO

-- Creating foreign key on [FacturaId] in table 'FacturaLineas'
ALTER TABLE [dbo].[FacturaLineas]
ADD CONSTRAINT [FK_FacturaFacturaLineas]
    FOREIGN KEY ([FacturaId])
    REFERENCES [dbo].[Factura]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaFacturaLineas'
CREATE INDEX [IX_FK_FacturaFacturaLineas]
ON [dbo].[FacturaLineas]
    ([FacturaId]);
GO

-- Creating foreign key on [FormaPagoId] in table 'Factura'
ALTER TABLE [dbo].[Factura]
ADD CONSTRAINT [FK_FormaPagoFactura]
    FOREIGN KEY ([FormaPagoId])
    REFERENCES [dbo].[FormaPago]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormaPagoFactura'
CREATE INDEX [IX_FK_FormaPagoFactura]
ON [dbo].[Factura]
    ([FormaPagoId]);
GO

-- Creating foreign key on [BodegaId] in table 'BodegaArticulo'
ALTER TABLE [dbo].[BodegaArticulo]
ADD CONSTRAINT [FK_BodegaBodegaArticulo]
    FOREIGN KEY ([BodegaId])
    REFERENCES [dbo].[Bodega]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BodegaBodegaArticulo'
CREATE INDEX [IX_FK_BodegaBodegaArticulo]
ON [dbo].[BodegaArticulo]
    ([BodegaId]);
GO

-- Creating foreign key on [FacturaId] in table 'Recibo'
ALTER TABLE [dbo].[Recibo]
ADD CONSTRAINT [FK_FacturaRecibo]
    FOREIGN KEY ([FacturaId])
    REFERENCES [dbo].[Factura]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaRecibo'
CREATE INDEX [IX_FK_FacturaRecibo]
ON [dbo].[Recibo]
    ([FacturaId]);
GO

-- Creating foreign key on [MinicipioId] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [FK_MinicipioClientes]
    FOREIGN KEY ([MinicipioId])
    REFERENCES [dbo].[Minicipio]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MinicipioClientes'
CREATE INDEX [IX_FK_MinicipioClientes]
ON [dbo].[Clientes]
    ([MinicipioId]);
GO

-- Creating foreign key on [DepartamentoId] in table 'Minicipio'
ALTER TABLE [dbo].[Minicipio]
ADD CONSTRAINT [FK_DepartamentoMinicipio]
    FOREIGN KEY ([DepartamentoId])
    REFERENCES [dbo].[Departamento]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartamentoMinicipio'
CREATE INDEX [IX_FK_DepartamentoMinicipio]
ON [dbo].[Minicipio]
    ([DepartamentoId]);
GO

-- Creating foreign key on [SexoId] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_SexoEmpleados]
    FOREIGN KEY ([SexoId])
    REFERENCES [dbo].[Sexo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SexoEmpleados'
CREATE INDEX [IX_FK_SexoEmpleados]
ON [dbo].[Empleados]
    ([SexoId]);
GO

-- Creating foreign key on [SexoId] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [FK_SexoClientes]
    FOREIGN KEY ([SexoId])
    REFERENCES [dbo].[Sexo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SexoClientes'
CREATE INDEX [IX_FK_SexoClientes]
ON [dbo].[Clientes]
    ([SexoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------