USE BBDD_KioscoLab3;
GO

-- Creamos la vista
CREATE VIEW view_DetallesArticulo AS
SELECT
    a.Nombre AS Articulo,
    a.Precio,
    a.Stock,
    a.Descripcion,
    c.Nombre AS Categoria,
    m.Nombre AS Marca,
    p.Nombre AS Proveedor
FROM Articulo a
INNER JOIN Categoria c ON a.id_Categoria = c.Id_Categoria
INNER JOIN Marca m ON a.id_Marca = m.id_Marca
INNER JOIN Proveedor p ON a.id_Proveedor = p.Id_proveedor;
GO


-- PROBAR VISTA
--USE BBDD_KioscoLab3
--SELECT * FROM Articulo

SELECT * FROM view_DetallesArticulo;