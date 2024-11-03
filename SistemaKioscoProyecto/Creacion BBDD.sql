USE MASTER
GO
CREATE DATABASE BBDD_KioscoLab3
GO 
USE BBDD_KioscoLab3
GO
 
CREATE TABLE Categoria (
    Id_Categoria INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(30) NOT NULL
);
 
CREATE TABLE Marca (
    id_Marca INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(30) NOT NULL
);

CREATE TABLE Ciudad (
    id_Ciudad INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    NombreCiudad VARCHAR(100) NOT NULL
);

CREATE TABLE Direccion (
    ID_Direccion INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Calle VARCHAR(40) NOT NULL,
    Altura INT NOT NULL,
    DescripcionProveedor VARCHAR(50) NOT NULL,
    id_Ciudad INT NOT NULL,
    FOREIGN KEY (id_Ciudad) REFERENCES Ciudad(id_Ciudad)
);

CREATE TABLE Proveedor (
    Id_proveedor INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    telefono INT NOT NULL,
    mail VARCHAR(50) NOT NULL UNIQUE,  
    id_direccion INT NOT NULL,
    FOREIGN KEY (id_direccion) REFERENCES Direccion(ID_Direccion)
);

CREATE TABLE Genero (
    id_Genero INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    NombreGenero VARCHAR(25) NOT NULL
);

CREATE TABLE Nacionalidad (
    id_nacionalidad INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    NombreNacionalidad VARCHAR(50) NOT NULL
);

CREATE TABLE Usuario (
    Id_Usuario INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Contrasenia VARCHAR(50) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Email VARCHAR(50) NOT NULL UNIQUE,
    FechaNacimiento DATE NOT NULL,
    FechaIngreso DATE NOT NULL,
    Dni VARCHAR(20) NOT NULL UNIQUE,
    Id_Nacionalidad INT NOT NULL,
    IDGenero INT NOT NULL,
    FOREIGN KEY (id_nacionalidad) REFERENCES Nacionalidad(id_nacionalidad),
    FOREIGN KEY (IDGenero) REFERENCES Genero(id_Genero)
);

CREATE TABLE Roles (
    Id_Rol INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(30) NOT NULL
);

CREATE TABLE Rol_X_Dni (
    Dni VARCHAR(20) PRIMARY KEY NOT NULL,
    Id_rol INT NOT NULL,
    FOREIGN KEY (Id_rol) REFERENCES Roles(Id_rol)
);

CREATE TABLE Articulo (
    Id_Articulo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(255) NULL,
    Stock INT NOT NULL,
    Precio DECIMAL(8,2) NOT NULL,  
    Estado BIT NOT NULL DEFAULT 1,  -- 1: Activo, 0: No Activo
    id_Categoria INT NOT NULL,
    id_Marca INT NOT NULL,
    id_Proveedor INT NOT NULL,
    FOREIGN KEY (id_Categoria) REFERENCES Categoria(Id_Categoria),
    FOREIGN KEY (id_Marca) REFERENCES Marca(id_Marca),
    FOREIGN KEY (id_Proveedor) REFERENCES Proveedor(Id_proveedor)
);

CREATE TABLE MetodoDePago (
    ID_MetodoDePago INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Metodo VARCHAR(30) NOT NULL
);

CREATE TABLE Venta (
    id_Venta INT NOT NULL PRIMARY KEY IDENTITY(1,1),  
    Fecha_Venta DATE NOT NULL,
    id_Metodo_Pago INT NOT NULL,
    Id_Usuario INT NOT NULL,
    FOREIGN KEY (Id_Usuario) REFERENCES Usuario(Id_Usuario),
    FOREIGN KEY (id_Metodo_Pago) REFERENCES MetodoDePago(ID_MetodoDePago)
);

CREATE TABLE Items_Ventas (
    Id_Item INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    Cantidad INT NOT NULL,
    id_Articulo INT NOT NULL,
    id_Venta INT NOT NULL,
    FOREIGN KEY (id_Articulo) REFERENCES Articulo(Id_Articulo),
    FOREIGN KEY (id_Venta) REFERENCES Venta(id_Venta)
);