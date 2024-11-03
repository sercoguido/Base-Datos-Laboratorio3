
CREATE PROCEDURE sp_ResumenArticulosPorMarca
    @IdMarca INT
AS
BEGIN
    SELECT 
        COUNT(*) AS CantidadArticulos,   
        AVG(Precio) AS PrecioPromedio 
    FROM 
        Articulo
    WHERE 
        id_Marca = @IdMarca
        AND Estado = 1; -- Solo voy a contar los artículos activos
END;

-- EJEMPLO DE USO:
USE BBDD_KioscoLab3
EXEC sp_ResumenArticulosPorMarca @IdMarca = 2;

