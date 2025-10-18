-- INSERTAR
INSERT INTO Producto (Descripcion, Precio)
VALUES ('Teclado Logitech', 15000);

SELECT * FROM Producto;

INSERT INTO Presupuesto (NombreDestinatario, FechaCreacion)
VALUES ('Carlos Ruiz', '2024-10-25');

SELECT * FROM Presupuesto;

INSERT INTO PresupuestoDetalle (idPresupuesto, idProducto, Cantidad) 
VALUES (1, 11, 5);

SELECT NombreDestinatario, IdProducto, Descripcion, Cantidad, Precio, Precio*Cantidad as Total 
FROM PresupuestoDetalle 
    INNER JOIN presupuesto using(IdPresupuesto) 
    INNER JOIN producto using(IdProducto); 


-- MODIFICAR
UPDATE Producto
SET Descripcion = 'Teclado Mecánico Logitech',
    Precio = 12000
WHERE idProducto = 12;

UPDATE Presupuesto 
SET NombreDestinatario = 'Modificado Ruiz' 
WHERE idPresupuesto = 1;


-- ELIMINAR
DELETE FROM PresupuestoDetalle WHERE idPresupuesto = 1 AND
idProducto = 12;