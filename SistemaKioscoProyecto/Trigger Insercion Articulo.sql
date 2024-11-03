-- CREO LA TABLA ARTICULOS POR INSERCCIONES 
CREATE TABLE Articulo_Inserciones (
    Id_Insercion INT PRIMARY KEY IDENTITY(1,1), 
    Id_Articulo INT NOT NULL,                    
    Nombre VARCHAR(50) NOT NULL,               
    FechaInsercion DATETIME DEFAULT GETDATE() 
);
GO

-- Trigger registrar cada inserccion en la tabla articulo
CREATE TRIGGER trg_AuditoriaInsercionArticulo
ON Articulo
AFTER INSERT 
AS
BEGIN
    INSERT INTO Articulo_Inserciones (Id_Articulo, Nombre)
    SELECT Id_Articulo, Nombre 
    FROM INSERTED;  
END;
GO


-- VER TABLA QUE INSERTA EL TRIGGER:
select * from Articulo_Inserciones