USE BBDD_KioscoLab3;
 
INSERT INTO Genero(NombreGenero) VALUES
('Femenino'),
('Masculino'),
('S/N');
 
INSERT INTO Ciudad(NombreCiudad) VALUES
('CABA'),
('BUENOS AIRES'),
('MENDOZA'),
('LUJAN'),
('Tigre');
 
INSERT INTO Marca(Nombre) VALUES
('Arcor'),
('Oreo'),
('Block'),
('Don Satur'),
('Coca Cola'),
('Pepsi'),
('Levite'),
('Aquarius'),
('Playadito'),
('La unión'),
('CBC'),
('Malboro'),
('Red Point');
 
INSERT INTO Direccion(Calle, Altura, DescripcionProveedor, id_Ciudad) 
VALUES 
    ('Libertador', 2568, 'Oficina Piso 7 ° B', 1),
    ('San Martin', 280, 'Parque Industrial "LOS PRODUCTORES"', 2), 
    ('San Martin', 9603, 'Parque Industrial "SAN MARTIN"', 4), 
    ('Av. de Mayo', 1234, 'Esquina con Av. Libertador', 5),
    ('Rivadavia', 5678, 'Frente a la plaza central', 3),
    ('Calle Guemes', 910, 'Entre la calle 1 y 2', 1), 
    ('Avenida Siempre Viva', 1112, 'Al lado del supermercado', 2);
 
INSERT INTO Proveedor (Nombre, telefono, mail, id_direccion)
VALUES 
    ('Distribuidora de Snacks S.A.', 1145678901, 'snacks@proveedor.com', 4),
    ('Bebidas Globales', 1123456789, 'bebidas@proveedor.com', 6),
    ('Productos de Cuidado S.A.', 1198765432, 'cuidado@proveedor.com', 3),
    ('Proveedores de Lácteos S.R.L.', 1156789012, 'lacteos@proveedor.com', 1),
    ('Comercializadora de Frutas Ltda.', 1167890123, 'frutas@proveedor.com', 5),
    ('Distribuciones Gourmet S.A.', 1178901234, 'gourmet@proveedor.com', 2),
    ('Alimentos Rápidos S.A.', 1189012345, 'rapidos@proveedor.com', 7); -- Se eliminó la coma aquí
 
INSERT INTO Categoria(Nombre) VALUES 
('Bebidas'),
('Galletitas'),
('Yerba'),
('Golosinas'),
('Cigarrillos'),
('Snacks'),
('Chicles'),
('Productos de Limpieza');
 
INSERT INTO MetodoDePago(Metodo) VALUES 
('Efectivo'),
('Tarjeta de crédito'),
('Tarjeta de débito'),
('Billetera virtual');
 
INSERT INTO Nacionalidad(NombreNacionalidad) VALUES 
('Argentina'),
('Chile'),
('Uruguay'),
('Paraguay'),
('Bolivia'),
('Brasil'),
('Perú');
 
INSERT INTO Articulo (Nombre, Stock, Precio, id_Categoria, id_Marca, id_Proveedor, Descripcion, Estado)
VALUES 
    ('Galletitas Sonrisas', 200, 2000, 2, 4, 1, 'Galletitas rellenas de chocolate y crema', 1),
    ('Refresco Cola', 150, 3000, 1, 5, 2, 'Bebida gaseosa sabor cola', 1),
    ('Yerba Mate Tradicional', 100, 5000, 3, 1, 3, 'Yerba mate elaborada sin palo', 1),
    ('Caramelos Menta', 250, 1500, 4, 6, 4, 'Caramelos refrescantes sabor menta', 1),
    ('Cigarrillos Paquete 35', 80, 8000, 5, 12, 5, 'Paquete de 35 cigarrillos', 1),
    ('Snack de Maíz', 300, 2500, 6, 2, 6, 'Snack de maíz horneado', 1),
    ('Chicles de Frutas', 400, 1200, 7, 13, 7, 'Chicles saborizados de frutas', 1),
    ('Limpiador Multiuso', 50, 1800, 8, 11, 1, 'Limpiador multiuso para superficies', 1),
    ('Galletitas de Chocolate', 150, 2500, 2, 4, 1, 'Galletitas sabor chocolate', 1),
    ('Agua Mineral', 300, 1200, 1, 7, 2, 'Agua mineral embotellada', 1),
    ('Mate Cocido', 200, 3500, 3, 1, 3, 'Bolsitas de mate cocido', 1),
    ('Chocolates Rellenos', 180, 3200, 4, 6, 4, 'Chocolates con relleno cremoso', 1),
    ('Cigarrillos Paquete 20', 90, 7500, 5, 12, 5, 'Paquete de 20 cigarrillos', 1),
    ('Barritas Energéticas', 220, 2800, 6, 11, 6, 'Barritas de granola y frutas', 1),
    ('Galletas Saladas', 250, 2200, 2, 4, 7, 'Galletitas con un toque de sal', 1),
    ('Bebida Deportiva', 130, 2900, 1, 5, 2, 'Bebida isotónica para deportistas', 1),
    ('Desinfectante', 75, 1500, 8, 13, 1, 'Desinfectante de uso doméstico', 1),
    ('Snacks de Frutos Secos', 160, 4500, 6, 2, 3, 'Snacks mixtos de frutos secos', 1);
 
INSERT INTO Roles (Nombre) 
VALUES 
    ('Administrador'),
    ('Empleado');
 
INSERT INTO Usuario (Contrasenia,Nombre, Apellido, email, FechaNacimiento, FechaIngreso, Dni, id_nacionalidad, IDGenero)
VALUES 
    ('Nosegura123','Juan', 'Pérez', 'juan.perez@example.com', '1990-05-15', '2023-01-10', '42345678', 1, 1),
    ('123','Ana', 'Gómez', 'ana.gomez@example.com', '1985-03-22', '2023-02-15', '57654321', 2, 3),
    ('123','Luis', 'Martínez', 'luis.martinez@example.com', '1992-08-30', '2023-03-05', '23456789', 1, 1),
    ('123','María', 'Fernández', 'maria.fernandez@example.com', '1988-12-11', '2023-01-20', '34567890', 1, 2),
    ('123','Pedro', 'López', 'pedro.lopez@example.com', '1995-07-19', '2023-04-25', '45678901', 4, 1);
 
INSERT INTO Rol_X_Dni (Dni, Id_rol) VALUES 
    ('42345678', 1),
    ('57654321', 2),
    ('23456789', 2),
    ('34567890', 2),
    ('45678901', 2);
 
INSERT INTO Venta (Fecha_Venta, id_Metodo_Pago, Id_Usuario)
VALUES 
    ('2024-10-28', 1, 1), 
    ('2024-10-28', 2, 1),  
    ('2024-10-29', 1, 3),  
    ('2024-10-29', 3, 4),  
    ('2024-10-03', 2, 5),  
    ('2024-11-01', 1, 1), 
    ('2024-11-01', 1, 2),  
    ('2024-11-02', 3, 5);  
 
INSERT INTO Items_Ventas (Cantidad, id_Articulo, id_Venta)
VALUES 
    (2, 1, 1),
    (3, 2, 1),
    (1, 3, 2),
    (5, 4, 3),
    (1, 5, 3),
    (2, 6, 4),
    (1, 7, 5),
    (4, 8, 6),
    (3, 1, 7),
    (2, 3, 8),
    (5, 1, 8);