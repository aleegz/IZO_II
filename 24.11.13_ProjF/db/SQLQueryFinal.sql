CREATE DATABASE tienda_ropa;

USE tienda_ropa;

CREATE TABLE usuarios (
	id_usuario INT PRIMARY KEY,
	usuario NVARCHAR(30),
	psw INT
);

CREATE TABLE marcas (
	id_marca INT PRIMARY KEY,
	descrip_marca NVARCHAR(60)
);

CREATE TABLE prendas (
	codigo INT,
	talle CHAR(5),
	color NVARCHAR(20),
	descrip_prenda NVARCHAR(60),
	stock INT,
	precio DEC(18, 2),
	id_marca INT FOREIGN KEY REFERENCES marcas(id_marca),
	PRIMARY KEY (codigo, talle, color)
);

CREATE TABLE clientes (
	id_cliente INT PRIMARY KEY,
	razon_social NVARCHAR(60),
	telefono NVARCHAR(60)
);

CREATE TABLE formas_pago (
	id_forma_pago INT PRIMARY KEY,
	descrip_forma_pago NVARCHAR(60)
);

CREATE TABLE ventas (
	id_venta INT PRIMARY KEY,
	fecha DATETIME,
	id_cliente INT FOREIGN KEY REFERENCES clientes(id_cliente),
	id_forma_pago INT FOREIGN KEY REFERENCES formas_pago(id_forma_pago),
	importe DEC(18, 2)
);

CREATE TABLE detalle_ventas (
	id_venta INT FOREIGN KEY REFERENCES ventas(id_venta),
	codigo INT,
	talle CHAR(5),
	color NVARCHAR(20),
	precio DEC(18, 2),
	cantidad INT,
	precio_r DEC(18, 2),
	FOREIGN KEY (codigo, talle, color) REFERENCES prendas(codigo, talle, color),
	PRIMARY KEY (codigo, talle, color, id_venta)
);


-- CREACIÓN DE SPU PARA CRUD --> PRENDAS, CLIENTES, FORMAS DE PAGO, MARCAS

-- CREACIÓN DE SP PRENDAS --

CREATE PROCEDURE spu_agregar_prenda
@codigo INT,
@talle CHAR(5),
@color NVARCHAR(20),
@descrip_prenda NVARCHAR(60),
@stock INT,
@precio DEC(18, 2)
AS
INSERT INTO prendas(codigo, talle, color, descrip_prenda, stock, precio)
VALUES
(@codigo, @talle, @color, @descrip_prenda, @stock, @precio);

------------------------------------------

CREATE PROCEDURE spu_mostrar_prendas
AS 
SELECT codigo AS CÓDIGO, talle AS TALLE, color AS COLOR, descrip_prenda AS DESCRIPCIÓN, stock AS STOCK, precio AS PRECIO FROM prendas;

------------------------------------------

CREATE PROCEDURE spu_actualizar_prenda
@codigo INT,
@talle CHAR(5),
@color NVARCHAR(20),
@descrip_prenda NVARCHAR(60),
@stock INT,
@precio DEC(18, 2)
AS
UPDATE prendas SET codigo = @codigo, talle = @talle, color = @color, descrip_prenda = @descrip_prenda, stock = @stock, precio = @precio
WHERE codigo = @codigo AND talle = @talle AND color = @color;

------------------------------------------

CREATE PROCEDURE spu_eliminar_prenda 
@codigo INT,
@talle CHAR(5),
@color NVARCHAR(20)
AS 
DELETE FROM prendas
WHERE codigo = @codigo AND talle = @talle AND color = @color;

------------------------------------------

CREATE PROCEDURE spu_obtener_prenda
@codigo INT,
@talle CHAR(5),
@color NVARCHAR(20)
AS
SELECT codigo AS CÓDIGO, talle AS TALLE, color AS COLOR, descrip_prenda AS DESCRIPCIÓN, stock AS STOCK, precio AS PRECIO FROM prendas
WHERE codigo = @codigo AND talle = @talle AND color = @color;

-- CREACIÓN DE SP CLIENTES --

CREATE PROCEDURE spu_agregar_cliente
@id_cliente INT,
@razon_social NVARCHAR(60),
@telefono NVARCHAR(60)
AS
INSERT INTO clientes(id_cliente, razon_social, telefono)
VALUES
(@id_cliente, @razon_social, @telefono);

------------------------------------------

CREATE PROCEDURE spu_mostrar_clientes
AS
SELECT id_cliente AS ID, razon_social AS RAZÓN_SOCIAL, telefono AS TELÉFONO FROM clientes;

------------------------------------------

CREATE PROCEDURE spu_actualizar_cliente
@id_cliente INT,
@razon_social NVARCHAR(60),
@telefono NVARCHAR(60)
AS
UPDATE clientes SET razon_social = @razon_social, telefono = @telefono
WHERE id_cliente = @id_cliente;

------------------------------------------

CREATE PROCEDURE spu_eliminar_cliente
@id_cliente INT
AS 
DELETE FROM clientes
WHERE id_cliente = @id_cliente;

------------------------------------------

CREATE PROCEDURE spu_obtener_cliente
@id_cliente INT
AS 
SELECT id_cliente AS ID, razon_social AS RAZÓN_SOCIAL, telefono AS TELÉFONO FROM clientes
WHERE id_cliente = @id_cliente;

-- CREACIÓN DE SP FORMAS DE PAGO --

CREATE PROCEDURE spu_agregar_forma_pago
@id_forma_pago INT,
@descrip_forma_pago NVARCHAR(60)
AS
INSERT INTO formas_pago(id_forma_pago, descrip_forma_pago)
VALUES
(@id_forma_pago, @descrip_forma_pago);

------------------------------------------

CREATE PROCEDURE spu_mostrar_formas_pago
AS
SELECT id_forma_pago AS ID, descrip_forma_pago AS DESCRIPCIÓN FROM formas_pago;

------------------------------------------

CREATE PROCEDURE spu_actualizar_forma_pago
@id_forma_pago INT,
@descrip_forma_pago NVARCHAR(60)
AS
UPDATE formas_pago SET descrip_forma_pago = @descrip_forma_pago
WHERE id_forma_pago = @id_forma_pago;

------------------------------------------

CREATE PROCEDURE spu_eliminar_forma_pago 
@id_forma_pago INT
AS
DELETE FROM formas_pago
WHERE id_forma_pago = @id_forma_pago;

------------------------------------------

CREATE PROCEDURE spu_obtener_forma_pago
@id_forma_pago INT
AS
SELECT id_forma_pago AS ID, descrip_forma_pago AS DESCRIPCIÓN FROM formas_pago
WHERE id_forma_pago = @id_forma_pago;

-- CREACIÓN DE SP MARCAS --

CREATE PROCEDURE spu_agregar_marca
@id_marca INT,
@descrip_marca NVARCHAR(60)
AS
INSERT INTO marcas(id_marca, descrip_marca)
VALUES
(@id_marca, @descrip_marca);

------------------------------------------

CREATE PROCEDURE spu_mostrar_marcas
AS
SELECT id_marca AS ID, descrip_marca AS DESCRIPCIÓN FROM marcas;

------------------------------------------

CREATE PROCEDURE spu_actualizar_marca
@id_marca INT,
@descrip_marca NVARCHAR(60)
AS
UPDATE marcas SET descrip_marca = @descrip_marca
WHERE id_marca = @id_marca;

------------------------------------------

CREATE PROCEDURE spu_eliminar_marca
@id_marca INT
AS
DELETE FROM marcas
WHERE id_marca = @id_marca;

------------------------------------------

CREATE PROCEDURE spu_obtener_marca
@id_marca INT
AS
SELECT id_marca AS ID, descrip_marca AS DESCRIPCIÓN FROM marcas
WHERE id_marca = @id_marca;

-- CREACIÓN DE SPU PARA VENTAS --

CREATE PROCEDURE spu_venta
@id_venta INT,
@fecha DATETIME,
@id_cliente INT,
@id_forma_pago INT,
@importe DEC(18, 2)
AS
INSERT INTO ventas(id_venta, fecha, id_cliente, id_forma_pago, importe)
VALUES
(@id_venta, @fecha, @id_cliente, @id_forma_pago, @importe);

-- CREACIÓN DE SPU PARA DETALLE DE VENTAS --

CREATE PROCEDURE spu_detalle_venta
@id_venta INT,
@talle CHAR(5),
@color NVARCHAR(20),
@precio DEC(18, 2),
@cantidad INT,
@precio_r DEC(18, 2)
AS
INSERT INTO detalle_ventas(id_venta, talle, color, precio, cantidad, precio_r)
VALUES
(@id_venta, @talle, @color, @precio, @cantidad, @precio_r);

-- CREACIÓN DE SPU PARA AUMENTO MASIVO DE PRECIOS POR MARCA --

CREATE PROCEDURE spu_aumento_masivo
@id_marca INT,
@porcentaje INT
AS
UPDATE prendas SET precio = precio * (@porcentaje / 100)
WHERE id_marca = @id_marca;

-- CREACIÓN DE SPU PARA LISTA DE PRECIOS --

-- misma que mostrar prendas (?

-- CREACIÓN DE SPU PARA VENTAS POR FECHA (EN PROCESO) --

CREATE PROCEDURE spu_ventas_fecha
@id_forma_pago INT
AS
SELECT fecha AS FECHA, id_venta AS ID, razon_social AS RAZON_SOCIAL, importe AS IMPORTE FROM ventas
INNER JOIN razon_social ON razon_social.id_cliente = razon_social.id_cliente;

-- CARGAR DATOS EN TABLAS --

INSERT INTO usuarios(id_usuario, usuario, psw)
VALUES
(1, 'Alejandro', 123),
(2, 'Pedro', 123),
(3, 'Juan', 456),
(4, 'Richard', 789),
(5, 'Germán', 123)

INSERT INTO marcas(id_marca, descrip_marca)
VALUES
(1, 'Adidas'),
(2, 'Nike'),
(3, 'Vans'),
(4, 'Equus'),
(5, 'Zara')

INSERT INTO prendas(codigo, talle, color, descrip_prenda, stock, precio, id_marca)
VALUES
(1, 'M', 'Blanco', 'Remera', 10, 10000, 1),
(2, 'M', 'Blanco', 'Remera', 20, 15000, 2),
(3, 'M', 'Blanco', 'Remera', 15, 20000, 3),
(4, 'M', 'Blanco', 'Remera', 30, 5000, 4),
(5, 'M', 'Blanco', 'Remera', 30, 40000, 5)

INSERT INTO clientes(id_cliente, razon_social, telefono)
VALUES
(1, 'Sport 78', '3414456434'),
(2, 'Fluid', '3412857728'),
(3, 'Digital Sport', '3416235124'),
(4, 'Balton Jeans', '3417757474'),
(5, 'Play On', '3416644414')

INSERT INTO formas_pago(id_forma_pago, descrip_forma_pago)
VALUES
(1, 'Efectivo'),
(2, 'Transferencia'),
(3, 'Débito'),
(4, 'Crédito'),
(5, 'Cuotas')

INSERT INTO ventas(id_venta, fecha, id_cliente, id_forma_pago, importe)
VALUES
(1, '01/10/2024', 1, 1, 11000),
(2, '01/10/2024', 2, 2, 13000),
(3, '01/10/2024', 3, 3, 20000),
(4, '01/10/2024', 4, 4, 1000),
(5, '01/10/2024', 5, 5, 15000)

INSERT INTO detalle_ventas(id_venta, codigo, talle, color, precio, cantidad, precio_r)
VALUES
(1, 1, 'M', 'Blanco', 10000, 1, 10000),
(2, 2, 'M', 'Blanco', 15000, 1, 15000),
(3, 3, 'M', 'Blanco', 20000, 1, 20000),
(4, 4, 'M', 'Blanco', 5000, 1, 5000),
(5, 5, 'M', 'Blanco', 40000, 1, 40000)