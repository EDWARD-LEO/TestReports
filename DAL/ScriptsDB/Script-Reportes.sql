-- DATASOURCE REPORTS
-- 1. Tablas
-- 2. Vistas (consultas)
-- 3. Procedimientos almacenados (consulta + variables)

USE Northwind
GO

CREATE VIEW vista_empleados_basica
AS
	SELECT EmployeeID, LastName, FirstName, Address, Country
	FROM Employees
GO

CREATE VIEW vista_productos_basica
AS
	SELECT	Products.ProductID, 
			Categories.CategoryName,
			Products.ProductName,
			Products.UnitsInStock,
			Products.UnitPrice
		FROM Products
		INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID
	GO
GO

SET LANGUAGE 'spanish'
GO


CREATE FUNCTION dbo.getNameMonth(@fecha DATE)
RETURNS VARCHAR(20)
AS 
BEGIN
	RETURN (SELECT DATENAME(MONTH, DATEADD(MONTH, MONTH(@fecha) - 1, '1900-01-01')))
END
GO

SELECT dbo.getNameMonth('2020-01-04')
GO

-- CREATE PROCEDURE 
CREATE PROCEDURE spu_pedidos_anio
@anio CHAR(4)
AS BEGIN
	SELECT	dbo.getNameMonth(OrderDate) 'mes',
			COUNT(OrderID) 'pedidos'
		FROM orders
		WHERE YEAR(OrderDate) = '1996'
		GROUP BY dbo.getNameMonth(OrderDate)
		ORDER BY 1
END
GO

EXEC spu_pedidos_anio '1996'
GO
