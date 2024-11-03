
---- ALTA MARCA
CREATE OR ALTER PROCEDURE AltaMarca
@NombreMarca VARCHAR(30)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO	Marca (Nombre) VALUES (@NombreMarca);

        
        COMMIT TRANSACTION;
        PRINT 'Marca agregado con éxito.';
    END TRY
    BEGIN CATCH
        -- Verifica si la transacción está activa antes de revertir
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        PRINT 'Ocurrió un error al intentar agregar la marca.';
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;


---- BAJA LOGICA MARCA
CREATE OR ALTER PROCEDURE BajaMarcaLogica
@IdMarca INT 
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Marca WHERE id_Marca = @IdMarca)
        BEGIN
            UPDATE Marca
            SET Estado = 0
            WHERE id_Marca = @IdMarca;
            
            PRINT 'Marca dado de baja lógicamente con éxito.';
            
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT 'Error: La marca con el Id especificado no existe.';
            
            COMMIT TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        PRINT 'Ocurrió un error al intentar dar de baja la marca.';
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;




---- MODIFICAR MARCA
CREATE OR ALTER PROCEDURE ModificarMarca
    @IdMarca INT,
    @NombreMarca VARCHAR(30)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Verificar si la marca existe
        IF EXISTS (SELECT 1 FROM Marca WHERE id_Marca = @IdMarca)
        BEGIN
            UPDATE Marca
            SET Nombre = @NombreMarca
            WHERE id_Marca = @IdMarca;

            PRINT 'Marca modificado con éxito.';
        END
        ELSE
        BEGIN
            PRINT 'Error: La marca con el Id especificado no existe.';
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        PRINT 'Ocurrió un error al intentar modificar la marca.';
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;


---- RESTABLECER MARCA
CREATE OR ALTER PROCEDURE RestablecerMarca
    @IdMarca INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Verifica que la marca exista y esté dado de baja
        IF EXISTS (SELECT 1 FROM Marca WHERE id_Marca = @IdMarca AND Estado = 0)
        BEGIN
            UPDATE Marca
            SET Estado = 1
            WHERE id_Marca = @IdMarca;
            
            PRINT 'Marca restablecido con éxito.';
            
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT 'Error: La marca con el Id especificado no existe o no está dado de baja.';
            COMMIT TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        PRINT 'Ocurrió un error al intentar restablecer la marca.';
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;



--EXECTUES DE PRUEBA
USE BBDD_KioscoLab3

EXEC AltaMarca
@NombreMarca='Manaos';

EXEC ModificarMarca
@IdMarca=14,
@NombreMarca='Nueva Marca';

EXEC BajaMarcaLogica @IdMarca=14;

EXEC RestablecerMarca @IdMarca=14;
