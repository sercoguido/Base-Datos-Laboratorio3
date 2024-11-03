
-----ALTA USUARIO
CREATE OR ALTER PROCEDURE AltaUsuario
@contrasenia VARCHAR(50),
@Nombre VARCHAR(100),
@Apellido VARCHAR(100),
@Email VARCHAR(50),
@FechaNacimiento DATE,
@FechaIngreso DATE,
@Dni VARCHAR(30),
@id_Nacionalidad INT,
@IdGenero INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Usuario (Contrasenia, Nombre, Apellido, Email, FechaNacimiento, FechaIngreso, Dni, Id_Nacionalidad, IDGenero)
        VALUES (@contrasenia, @Nombre, @Apellido, @Email, @FechaNacimiento, @FechaIngreso, @Dni, @id_Nacionalidad, @IdGenero);

        
        COMMIT TRANSACTION;
        PRINT 'Usuario agregado con éxito.';
    END TRY
    BEGIN CATCH
        -- Verifica si la transacción está activa antes de revertir
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        PRINT 'Ocurrió un error al intentar agregar el usuario.';
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;




-------- BAJA LOGICA USUARIO
CREATE OR ALTER PROCEDURE BajaUsuarioLogica
@IdUsuario INT 
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Usuario WHERE Id_Usuario = @IdUsuario)
        BEGIN
            UPDATE Usuario
            SET Estado = 0
            WHERE Id_Usuario = @IdUsuario;
            
            PRINT 'Usuario dado de baja lógicamente con éxito.';
            
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT 'Error: El Usuario con el Id especificado no existe.';
            
            COMMIT TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        PRINT 'Ocurrió un error al intentar dar de baja el Usuario.';
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;


----- MODIFICAR USUARIO
CREATE OR ALTER PROCEDURE ModificarUsuario
@IdUsuario INT,
@contrasenia VARCHAR(50),
@Nombre VARCHAR(100),
@Apellido VARCHAR(100),
@Email VARCHAR(50),
@FechaNacimiento DATE,
@FechaIngreso DATE,
@Dni VARCHAR(30),
@id_Nacionalidad INT,
@IdGenero INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Verificar si el usuario existe
        IF EXISTS (SELECT 1 FROM Usuario WHERE Id_Usuario = @IdUsuario)
        BEGIN
            UPDATE Usuario
            SET Nombre = @Nombre,
                Apellido = @Apellido,
                Email = @Email,
                FechaNacimiento = @FechaNacimiento,
                FechaIngreso = @FechaIngreso,
                Dni = @Dni,
                Id_Nacionalidad = @id_Nacionalidad,
				IDGenero=@IdGenero
            WHERE Id_Usuario = @IdUsuario;

            PRINT 'Usuario modificado con éxito.';
        END
        ELSE
        BEGIN
            PRINT 'Error: El usuario con el Id especificado no existe.';
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        PRINT 'Ocurrió un error al intentar modificar el usuario.';
        
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;


---- RESTABLECER USUARIO
CREATE OR ALTER PROCEDURE RestablecerUsuario
    @IdUsuario INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Verifica que el artículo exista y esté dado de baja
        IF EXISTS (SELECT 1 FROM Usuario WHERE Id_Usuario = @Id_Usuario AND Estado = 0)
        BEGIN
            UPDATE Usuario
            SET Estado = 1
            WHERE Id_Usuario = @Id_Usuario;
            
            PRINT 'Usuario restablecido con éxito.';
            
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT 'Error: El usuario con el Id especificado no existe o no está dado de baja.';
            COMMIT TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        PRINT 'Ocurrió un error al intentar restablecer el usuario.';
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        PRINT @ErrorMessage;
    END CATCH
END;





-- EXECUTES DE PRUEBA
USE BBDD_KioscoLab3

EXEC AltaUsuario
@contrasenia='1234',
@Nombre='Armando',
@Apellido='Perez',
@Email='armando.perez@example.com',
@FechaNacimiento='1991-01-10',
@FechaIngreso='2023-05-01',
@Dni=42444567,
@id_Nacionalidad=1,
@IdGenero=1;

EXEC ModificarUsuario
@IdUsuario=6,
@contrasenia='abc123',
@Nombre='Armando',
@Apellido='Perez',
@Email='armando.perez@gmail.com',
@FechaNacimiento='1990-05-15',
@FechaIngreso='2023-01-10',
@Dni=42444567,
@id_Nacionalidad=1,
@IdGenero=1;

EXEC BajaUsuarioLogica @IdUsuario=6;

EXEC RestablecerUsuario @IdUsuario=6;