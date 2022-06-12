
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/12/2022 15:24:50
-- Generated from EDMX file: D:\Tomi Pascual\Desktop\Tomas\Facultad\Ing en Sistemas\2do año\P.O.O\Trabajo-Practico-Prog\EjemploVista\Model\Contexto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [basededatos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [DNI] nvarchar(max)  NOT NULL,
    [Contraseña] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Perfiles'
CREATE TABLE [dbo].[Perfiles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Formularios'
CREATE TABLE [dbo].[Formularios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Permisos'
CREATE TABLE [dbo].[Permisos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UsuarioPerfil'
CREATE TABLE [dbo].[UsuarioPerfil] (
    [Usuario_Id] int  NOT NULL,
    [Perfil_Id] int  NOT NULL
);
GO

-- Creating table 'PerfilFormulario'
CREATE TABLE [dbo].[PerfilFormulario] (
    [Perfil_Id] int  NOT NULL,
    [Formulario_Id] int  NOT NULL
);
GO

-- Creating table 'FormularioPermiso'
CREATE TABLE [dbo].[FormularioPermiso] (
    [Formulario_Id] int  NOT NULL,
    [Permiso_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [PK_Perfiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Formularios'
ALTER TABLE [dbo].[Formularios]
ADD CONSTRAINT [PK_Formularios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Permisos'
ALTER TABLE [dbo].[Permisos]
ADD CONSTRAINT [PK_Permisos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Usuario_Id], [Perfil_Id] in table 'UsuarioPerfil'
ALTER TABLE [dbo].[UsuarioPerfil]
ADD CONSTRAINT [PK_UsuarioPerfil]
    PRIMARY KEY CLUSTERED ([Usuario_Id], [Perfil_Id] ASC);
GO

-- Creating primary key on [Perfil_Id], [Formulario_Id] in table 'PerfilFormulario'
ALTER TABLE [dbo].[PerfilFormulario]
ADD CONSTRAINT [PK_PerfilFormulario]
    PRIMARY KEY CLUSTERED ([Perfil_Id], [Formulario_Id] ASC);
GO

-- Creating primary key on [Formulario_Id], [Permiso_Id] in table 'FormularioPermiso'
ALTER TABLE [dbo].[FormularioPermiso]
ADD CONSTRAINT [PK_FormularioPermiso]
    PRIMARY KEY CLUSTERED ([Formulario_Id], [Permiso_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Usuario_Id] in table 'UsuarioPerfil'
ALTER TABLE [dbo].[UsuarioPerfil]
ADD CONSTRAINT [FK_UsuarioPerfil_Usuario]
    FOREIGN KEY ([Usuario_Id])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Perfil_Id] in table 'UsuarioPerfil'
ALTER TABLE [dbo].[UsuarioPerfil]
ADD CONSTRAINT [FK_UsuarioPerfil_Perfil]
    FOREIGN KEY ([Perfil_Id])
    REFERENCES [dbo].[Perfiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPerfil_Perfil'
CREATE INDEX [IX_FK_UsuarioPerfil_Perfil]
ON [dbo].[UsuarioPerfil]
    ([Perfil_Id]);
GO

-- Creating foreign key on [Perfil_Id] in table 'PerfilFormulario'
ALTER TABLE [dbo].[PerfilFormulario]
ADD CONSTRAINT [FK_PerfilFormulario_Perfil]
    FOREIGN KEY ([Perfil_Id])
    REFERENCES [dbo].[Perfiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Formulario_Id] in table 'PerfilFormulario'
ALTER TABLE [dbo].[PerfilFormulario]
ADD CONSTRAINT [FK_PerfilFormulario_Formulario]
    FOREIGN KEY ([Formulario_Id])
    REFERENCES [dbo].[Formularios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilFormulario_Formulario'
CREATE INDEX [IX_FK_PerfilFormulario_Formulario]
ON [dbo].[PerfilFormulario]
    ([Formulario_Id]);
GO

-- Creating foreign key on [Formulario_Id] in table 'FormularioPermiso'
ALTER TABLE [dbo].[FormularioPermiso]
ADD CONSTRAINT [FK_FormularioPermiso_Formulario]
    FOREIGN KEY ([Formulario_Id])
    REFERENCES [dbo].[Formularios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Permiso_Id] in table 'FormularioPermiso'
ALTER TABLE [dbo].[FormularioPermiso]
ADD CONSTRAINT [FK_FormularioPermiso_Permiso]
    FOREIGN KEY ([Permiso_Id])
    REFERENCES [dbo].[Permisos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormularioPermiso_Permiso'
CREATE INDEX [IX_FK_FormularioPermiso_Permiso]
ON [dbo].[FormularioPermiso]
    ([Permiso_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------