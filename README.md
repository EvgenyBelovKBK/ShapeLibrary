# ShapeLibrary
###
Задание №2:

```SQL
CREATE DATABASE ProductCategoryTest

CREATE TABLE Product
(
ProductId INT PRIMARY KEY IDENTITY(1,1),
Name nvarchar(255) NOT NULL
);

CREATE TABLE Category
(
CategoryId INT PRIMARY KEY IDENTITY(1,1),
Name nvarchar(255) NOT NULL
);

CREATE TABLE ProductCategory
(
ProductId INT NOT NULL REFERENCES Product(ProductId), 
CategoryId INT NOT NULL REFERENCES Category(CategoryId),
PRIMARY KEY(ProductId, CategoryId)
);

INSERT INTO Product (Name) VALUES
(N'Apple'),
(N'Shirt'),
(N'Cookie'),
(N'Laptop')

INSERT INTO Category (Name) VALUES
(N'Food'),
(N'Fruit'),
(N'Clothing'),
(N'Detergents')

INSERT INTO ProductCategory (ProductId, CategoryId) VALUES
(1, 1),
(1, 2),
(2, 3),
(3, 1)

Select p.Name as ProductName, c.Name as CategoryName FROM Product p
LEFT OUTER JOIN ProductCategory pc on pc.ProductId = p.ProductId
LEFT OUTER JOIN Category c on c.CategoryId = pc.CategoryId

--DROP DATABASE ProductCategoryTest

```
