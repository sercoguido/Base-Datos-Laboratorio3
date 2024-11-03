
---------------ALTA ARTICULO
CREATE OR ALTER PROCEDURE AltaArticulo 
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(255),
    @Precio DECIMAL(18, 2),
    @Stock INT,
    @Id_Marca INT,
    @Id_Categoria INT,
    @Id_Proveedor INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Articulo (Nombre, Descripcion, Precio, Stock, Id_Marca, Id_Categoria, Id_Proveedor, Estado)
        VALUES (@Nombre, @Descripcion, @Precio, @Stock, @Id_Marca, @Id_Categoria, @Id_Proveedor, 1);

        
        COMMIT TRANSACTION; -- Confirma la transacción
        PRINT 'Artículo agregado con éxito.';
    END TRY
    BEGIN CATCH
        -- Verifica si la transacción está activa antes de revertir
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        PRINT 'Ocurrió un error al intentar agregar el artículo.';
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;





---------------BAJA LOGICA ARTICULO



CREATE OR ALTER PROCEDURE BajaArticuloLogica
    @Id_Articulo INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Articulo WHERE Id_Articulo = @Id_Articulo)
        BEGIN
            UPDATE Articulo
            SET Estado = 0
            WHERE Id_Articulo = @Id_Articulo;
            
            PRINT 'Artículo dado de baja lógicamente con éxito.';
            
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT 'Error: El artículo con el Id especificado no existe.';
            
            COMMIT TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        PRINT 'Ocurrió un error al intentar dar de baja el artículo.';
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;





---------------MODIFICACION ARTICULO


CREATE OR ALTER PROCEDURE ModificarArticulo
    @Id_Articulo INT,
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(255),
    @Precio DECIMAL(18, 2),
    @Stock INT,
    @Id_Marca INT,
    @Id_Categoria INT,
    @Id_Proveedor INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Verificar si el artículo existe
        IF EXISTS (SELECT 1 FROM Articulo WHERE Id_Articulo = @Id_Articulo)
        BEGIN
            UPDATE Articulo
            SET Nombre = @Nombre,
                Descripcion = @Descripcion,
                Precio = @Precio,
                Stock = @Stock,
                Id_Marca = @Id_Marca,
                Id_Categoria = @Id_Categoria,
                Id_Proveedor = @Id_Proveedor
            WHERE Id_Articulo = @Id_Articulo;

            PRINT 'Artículo modificado con éxito.';
        END
        ELSE
        BEGIN
            PRINT 'Error: El artículo con el Id especificado no existe.';
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        PRINT 'Ocurrió un error al intentar modificar el artículo.';
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;




---------------REESTABLECER ARTICULO


CREATE OR ALTER PROCEDURE RestablecerArticulo
    @Id_Articulo INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Verifica que el artículo exista y esté dado de baja
        IF EXISTS (SELECT 1 FROM Articulo WHERE Id_Articulo = @Id_Articulo AND Estado = 0)
        BEGIN
            UPDATE Articulo
            SET Estado = 1
            WHERE Id_Articulo = @Id_Articulo;
            
            PRINT 'Artículo restablecido con éxito.';
            
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT 'Error: El artículo con el Id especificado no existe o no está dado de baja.';
            COMMIT TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        PRINT 'Ocurrió un error al intentar restablecer el artículo.';
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;




-- EXECUTES DE PRUEBA---------------

USE BBDD_KioscoLab3

EXEC AltaArticulo
    @Nombre = N'Bolígrafo Azul',
    @Descripcion = N'Bolígrafo con tinta azul de punta fina',
    @Precio = 15.50,
    @Stock = 100,
    @Id_Marca = 1,
    @Id_Categoria = 2,
    @Id_Proveedor = 3;


EXEC BajaArticuloLogica @Id_Articulo = 21;

EXEC RestablecerArticulo @Id_Articulo = 21;

EXEC ModificarArticulo 
    @Id_Articulo = 21,
    @Nombre = 'Nuevo NomBre',
    @Descripcion = 'Nueva Descripción',
    @Precio = 99.99,
    @Stock = 50,
    @Id_Marca = 2,
    @Id_Categoria = 3;