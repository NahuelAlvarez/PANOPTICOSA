IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Jefe] (
    [IdJefe] int NOT NULL IDENTITY,
    [IdEmpleado] int NOT NULL,
    [Tipo] varchar(20) NOT NULL,
    CONSTRAINT [PK_Jefe] PRIMARY KEY ([IdJefe])
);

GO

CREATE TABLE [Persona] (
    [IdPersona] int NOT NULL IDENTITY,
    [Dni] int NOT NULL,
    [Nombre] varchar(50) NULL,
    [Apellido] varchar(50) NULL,
    [IdDomicilio] int NOT NULL,
    [Fecha_Nacimiento] datetime2 NULL,
    [Telefono] varchar(20) NULL,
    [Email] varchar(50) NULL,
    CONSTRAINT [PK_Persona] PRIMARY KEY ([IdPersona])
);

GO

CREATE TABLE [Servicio] (
    [IdServicio] int NOT NULL IDENTITY,
    [Tipo] varchar(50) NULL,
    [Descripcion] varchar(150) NULL,
    [Observaciones] varchar(150) NULL,
    CONSTRAINT [PK_Servicio] PRIMARY KEY ([IdServicio])
);

GO

CREATE TABLE [Area] (
    [IdArea] int NOT NULL IDENTITY,
    [Tipo] varchar(50) NULL,
    [IdJefe] int NOT NULL,
    CONSTRAINT [PK_Area] PRIMARY KEY ([IdArea]),
    CONSTRAINT [FK_Area_Jefe] FOREIGN KEY ([IdJefe]) REFERENCES [Jefe] ([IdJefe]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Cliente] (
    [IdCliente] int NOT NULL IDENTITY,
    [IdPersona] int NOT NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY ([IdCliente]),
    CONSTRAINT [FK_Cliente_Persona] FOREIGN KEY ([IdPersona]) REFERENCES [Persona] ([IdPersona]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Domicilio] (
    [IdDomicilio] int NOT NULL IDENTITY,
    [Calle] varchar(50) NOT NULL,
    [Numero] int NOT NULL,
    [Departamento] varchar(50) NULL,
    [Piso] int NULL,
    [Provincia] varchar(50) NOT NULL,
    [Ciudad] varchar(50) NOT NULL,
    [CP] int NOT NULL,
    [IdPersona] int NULL,
    [Barrio] varchar(100) NULL,
    CONSTRAINT [PK_Domicilio] PRIMARY KEY ([IdDomicilio]),
    CONSTRAINT [FK_Domicilio_Persona] FOREIGN KEY ([IdPersona]) REFERENCES [Persona] ([IdPersona]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Empleado] (
    [IdEmpleado] int NOT NULL IDENTITY,
    [Sueldo] money NULL,
    [IdPersona] int NOT NULL,
    CONSTRAINT [PK_Empleado] PRIMARY KEY ([IdEmpleado]),
    CONSTRAINT [FK_Empleado_Persona] FOREIGN KEY ([IdPersona]) REFERENCES [Persona] ([IdPersona]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Presupuesto] (
    [IdPresupuesto] int NOT NULL IDENTITY,
    [IdJefe] int NOT NULL,
    [IdServicio] int NOT NULL,
    CONSTRAINT [PK_Presupuesto] PRIMARY KEY ([IdPresupuesto]),
    CONSTRAINT [FK_Presupuesto_Jefe] FOREIGN KEY ([IdJefe]) REFERENCES [Jefe] ([IdJefe]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Presupuesto_Servicio] FOREIGN KEY ([IdServicio]) REFERENCES [Servicio] ([IdServicio]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Cliente_Contrata] (
    [IdCliente] int NOT NULL,
    [IdServicio] int NOT NULL,
    CONSTRAINT [PK_Cliente_Contrata] PRIMARY KEY ([IdCliente], [IdServicio]),
    CONSTRAINT [FK_Cliente_Contrata_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [Cliente] ([IdCliente]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cliente_Contrata_Servicio] FOREIGN KEY ([IdServicio]) REFERENCES [Servicio] ([IdServicio]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Cliente_Opina] (
    [IdCliente] int NOT NULL,
    [IdServicio] int NOT NULL,
    CONSTRAINT [PK_Cliente_Opina] PRIMARY KEY ([IdCliente], [IdServicio]),
    CONSTRAINT [FK_Cliente_Opina_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [Cliente] ([IdCliente]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cliente_Opina_Servicio] FOREIGN KEY ([IdServicio]) REFERENCES [Servicio] ([IdServicio]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Cuenta] (
    [IdCuenta] int NOT NULL IDENTITY,
    [IdCliente] int NOT NULL,
    [Monto] money NULL,
    [Fecha_Pago] datetime2 NULL,
    [Fecha_Vencimiento] datetime2 NULL,
    [Estado] varchar(50) NULL,
    CONSTRAINT [PK_Cuenta_1] PRIMARY KEY ([IdCuenta], [IdCliente]),
    CONSTRAINT [FK_Cuenta_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [Cliente] ([IdCliente]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Emergencia] (
    [IdEmergencia] int NOT NULL IDENTITY,
    [IdCliente] int NOT NULL,
    [IdJefe] int NOT NULL,
    CONSTRAINT [PK_Emergencia] PRIMARY KEY ([IdEmergencia]),
    CONSTRAINT [FK_Emergencia_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [Cliente] ([IdCliente]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Turno] (
    [IdTurno] int NOT NULL IDENTITY,
    [Fecha] date NULL,
    [Hora] time NULL,
    [IdCliente] int NOT NULL,
    [IdServicio] int NOT NULL,
    [Estado] varchar(50) NULL,
    CONSTRAINT [PK_Turno] PRIMARY KEY ([IdTurno]),
    CONSTRAINT [FK_Turno_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [Cliente] ([IdCliente]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Turno_Servicio] FOREIGN KEY ([IdServicio]) REFERENCES [Servicio] ([IdServicio]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Tecnico] (
    [IdTecnico] int NOT NULL IDENTITY,
    [IdEmpleado] int NOT NULL,
    CONSTRAINT [PK_Tecnico] PRIMARY KEY ([IdTecnico]),
    CONSTRAINT [FK_Tecnico_Empleado] FOREIGN KEY ([IdEmpleado]) REFERENCES [Empleado] ([IdEmpleado]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Factura] (
    [IdFactura] int NOT NULL IDENTITY,
    [Nro] int NOT NULL,
    [IdCuenta] int NOT NULL,
    [IdCliente] int NOT NULL,
    [Fecha] date NULL,
    CONSTRAINT [PK_Factura] PRIMARY KEY ([IdFactura]),
    CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY ([IdCliente]) REFERENCES [Cliente] ([IdCliente]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Factura_Cuenta] FOREIGN KEY ([IdCuenta], [IdCliente]) REFERENCES [Cuenta] ([IdCuenta], [IdCliente]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Servicio_Tecnico] (
    [IdTurno] int NOT NULL,
    [IdTecnico] int NOT NULL,
    CONSTRAINT [PK_Servicio_Tecnico] PRIMARY KEY ([IdTurno], [IdTecnico]),
    CONSTRAINT [FK_Servicio_Tecnico_Tecnico] FOREIGN KEY ([IdTecnico]) REFERENCES [Tecnico] ([IdTecnico]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Servicio_Tecnico_Servicio] FOREIGN KEY ([IdTurno]) REFERENCES [Servicio] ([IdServicio]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Area_IdJefe] ON [Area] ([IdJefe]);

GO

CREATE INDEX [IX_Cliente_IdPersona] ON [Cliente] ([IdPersona]);

GO

CREATE INDEX [IX_Cliente_Contrata_IdServicio] ON [Cliente_Contrata] ([IdServicio]);

GO

CREATE INDEX [IX_Cliente_Opina_IdServicio] ON [Cliente_Opina] ([IdServicio]);

GO

CREATE INDEX [IX_Cuenta_IdCliente] ON [Cuenta] ([IdCliente]);

GO

CREATE INDEX [IX_Domicilio_IdPersona] ON [Domicilio] ([IdPersona]);

GO

CREATE INDEX [IX_Emergencia_IdCliente] ON [Emergencia] ([IdCliente]);

GO

CREATE INDEX [IX_Empleado_IdPersona] ON [Empleado] ([IdPersona]);

GO

CREATE INDEX [IX_Factura_IdCliente] ON [Factura] ([IdCliente]);

GO

CREATE INDEX [IX_Factura_IdCuenta_IdCliente] ON [Factura] ([IdCuenta], [IdCliente]);

GO

CREATE INDEX [IX_Presupuesto_IdJefe] ON [Presupuesto] ([IdJefe]);

GO

CREATE INDEX [IX_Presupuesto_IdServicio] ON [Presupuesto] ([IdServicio]);

GO

CREATE INDEX [IX_Servicio_Tecnico_IdTecnico] ON [Servicio_Tecnico] ([IdTecnico]);

GO

CREATE INDEX [IX_Tecnico_IdEmpleado] ON [Tecnico] ([IdEmpleado]);

GO

CREATE INDEX [IX_Turno_IdCliente] ON [Turno] ([IdCliente]);

GO

CREATE INDEX [IX_Turno_IdServicio] ON [Turno] ([IdServicio]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191128042644_InitialDB', N'2.2.6-servicing-10079');

GO

