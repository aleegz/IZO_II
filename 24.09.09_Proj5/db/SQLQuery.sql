-- CREACIÓN DE BASE DE DATOS

CREATE DATABASE proy5;

-- USAR BASE DE DATOS 

USE proy5;

-- CREACIÓN DE TABLAS

CREATE TABLE sucursales(
	id_sucursal INT PRIMARY KEY IDENTITY,
	descripcion NVARCHAR(60),
	localidad NVARCHAR(60) 
)

CREATE TABLE vendedores(
	id_vendedor INT PRIMARY KEY,
	nombre NVARCHAR(60),
	psw NVARCHAR(60),
	id_sucursal INT FOREIGN KEY REFERENCES sucursales(id_sucursal)
)

CREATE TABLE ventas(
	id_venta INT PRIMARY KEY,
	fecha DATE,
	importe DEC(18, 2),
	id_vendedor INT FOREIGN KEY REFERENCES vendedores(id_vendedor)
)

-- CREACIÓN DE SP SUCURSALES --

CREATE PROCEDURE spu_agregar_sucursal
@id_sucursal INT,
@descripcion NVARCHAR(60),
@localidad NVARCHAR(60)
AS
INSERT INTO sucursales (id_sucursal, descripcion, localidad)
VALUES
(@id_sucursal, @descripcion, @localidad);

------------------------------------------

CREATE PROCEDURE spu_mostrar_sucursales
AS
SELECT id_sucursal AS ID, descripcion AS DESCRIPCION, localidad AS LOCALIDAD FROM sucursales

------------------------------------------

CREATE PROCEDURE spu_actualizar_sucursal
@id_sucursal INT,
@descripcion NVARCHAR(60),
@localidad NVARCHAR(60)
AS
UPDATE sucursales SET descripcion = @descripcion, localidad = @localidad
WHERE id_sucursal = @id_sucursal

------------------------------------------

CREATE PROCEDURE spu_eliminar_sucursal
@id_sucursal INT
AS
DELETE FROM sucursales 
WHERE id_sucursal = @id_sucursal

------------------------------------------

CREATE PROCEDURE spu_obtener_id_sucursal
@id_sucursal INT
AS 
SELECT id_sucursal AS ID, descripcion AS DESCRIPCION, localidad AS LOCALIDAD FROM sucursales
WHERE id_sucursal = @id_sucursal


-- CREACIÓN DE SP VENDEDORES --

CREATE PROCEDURE spu_agregar_vendedor
@id_vendedor INT,
@nombre NVARCHAR(60),
@psw NVARCHAR(60),
@id_sucursal INT
AS
INSERT INTO vendedores(id_vendedor, nombre, psw, id_sucursal)
VALUES
(@id_vendedor, @nombre, @psw, @id_sucursal);

------------------------------------------

CREATE PROCEDURE spu_mostrar_vendedores
AS
SELECT id_vendedor AS ID, nombre AS NOMBRE, id_sucursal AS ID_SUCURSAL FROM vendedores;

------------------------------------------

CREATE PROCEDURE spu_actualizar_vendedor
@id_vendedor INT,
@nombre NVARCHAR(60),
@psw NVARCHAR(60),
@id_sucursal INT
AS
UPDATE vendedores SET nombre = @nombre, psw = @psw, id_sucursal = @id_sucursal
WHERE id_vendedor = @id_vendedor

------------------------------------------

CREATE PROCEDURE spu_eliminar_vendedor
@id_vendedor INT
AS
DELETE FROM vendedores 
WHERE id_vendedor = @id_vendedor

------------------------------------------

CREATE PROCEDURE spu_obtener_id_vendedor
@id_vendedor INT
AS 
SELECT id_vendedor AS ID, nombre AS NOMBRE, psw AS CONTRASEÑA, id_sucursal AS SUCURSAL FROM vendedores
WHERE id_vendedor = @id_vendedor


-- CREACIÓN DE SP VENTAS --

CREATE PROCEDURE spu_agregar_venta
@id_venta INT,
@fecha DATETIME,
@importe DEC(18, 2),
@id_vendedor INT
AS
INSERT INTO ventas(id_venta, fecha, importe, id_vendedor)
VALUES
(@id_venta, @fecha, @importe, @id_vendedor);

------------------------------------------

CREATE PROCEDURE spu_mostrar_ventas
AS
SELECT id_venta AS ID, fecha AS FECHA, importe AS IMPORTE, id_vendedor AS VENDEDOR FROM ventas;

------------------------------------------

CREATE PROCEDURE spu_actualizar_venta
@id_venta INT,
@fecha DATE,
@importe DEC(10, 2),
@id_vendedor INT
AS
UPDATE ventas SET fecha = @fecha, importe = @importe, id_vendedor = @id_vendedor
WHERE id_venta = @id_venta

------------------------------------------

CREATE PROCEDURE spu_eliminar_venta
@id_venta INT
AS
DELETE FROM ventas 
WHERE id_venta = @id_venta

------------------------------------------

CREATE PROCEDURE spu_obtener_id_venta
@id_venta INT
AS 
SELECT id_venta AS ID, fecha AS FECHA, importe AS IMPORTE, id_vendedor AS VENDEDOR FROM ventas
WHERE id_venta = @id_venta

------------------------------------------

CREATE PROCEDURE spu_promedio
@id_vendedor INT
AS 
SELECT AVG(importe) FROM ventas WHERE id_vendedor = @id_vendedor

------------------------------------------

CREATE PROCEDURE spu_ventas_localidad
AS
SELECT sucursales.localidad, SUM(ventas.importe) AS INGRESOS FROM ventas
INNER JOIN sucursales ON sucursales.id_sucursal = ventas.id_vendedor
GROUP BY sucursales.localidad
ORDER BY SUM(ventas.importe) DESC

------------------------------------------

CREATE PROCEDURE spu_vendedores_sucursales
AS
SELECT id_vendedor AS ID, nombre AS NOMBRE, sucursales.localidad AS LOCALIDAD, sucursales.descripcion AS SUCURSAL FROM vendedores
INNER JOIN sucursales ON sucursales.id_sucursal = vendedores.id_sucursal

------------------------------------------

CREATE PROCEDURE spu_ventas_vendedor
AS
SELECT id_venta AS ID, fecha AS FECHA, importe AS IMPORTE, id_vendedor AS VENDEDOR, sucursales.localidad AS LOCALIDAD FROM ventas
INNER JOIN sucursales ON sucursales.id_sucursal = ventas.id_vendedor

------------------------------------------

CREATE PROCEDURE spu_ventas_fecha
@fecha_d NVARCHAR(20),
@fecha_h NVARCHAR(20)
AS
SELECT id_venta AS ID, fecha AS FECHA, importe AS IMPORTE, id_vendedor AS VENDEDOR FROM ventas
WHERE fecha BETWEEN @fecha_d AND @fecha_h

------------------------------------------

CREATE PROCEDURE spu_vendedor_ventas
@id_vendedor INT
AS
SELECT id_venta AS ID, fecha AS FECHA, importe AS IMPORTE, id_vendedor AS VENDEDOR FROM ventas
WHERE id_vendedor = @id_vendedor

------------------------------------------


-- INGRESO DE DATOS

INSERT INTO sucursales 
VALUES
(1, 'Sucursal 1', 'Buenos Aires'),
(2, 'Sucursal 2', 'Rosario'),
(3, 'Sucursal 3', 'Córdoba')

INSERT INTO vendedores
VALUES
(1, 'Ramón', '123', 1),
(2, 'Carlos', '456', 2),
(3, 'Juan', '789', 3)

INSERT INTO ventas 
VALUES
(1, '21/8/24', 10000, 1),
(2, '21/8/24', 1000, 2),
(3, '21/8/24', 15000, 3)