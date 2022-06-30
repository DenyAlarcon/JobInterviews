CREATE DATABASE MindboxDB;
USE MindboxDB;

CREATE TABLE Products 
(
	Id INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(100) NOT NULL
);

CREATE TABLE Categories
(
	Id INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(100) NOT NULL
);

CREATE TABLE ProductsCategories
(
	ProductId INT FOREIGN KEY REFERENCES Products(Id) ON DELETE CASCADE NOT NULL ,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) ON DELETE CASCADE NOT NULL
);

INSERT INTO Products VALUES (1, 'Product1');
INSERT INTO Products VALUES (2, 'Product2');
INSERT INTO Products VALUES (3, 'Product3');
INSERT INTO Products VALUES (4, 'Product4');

INSERT INTO Categories VALUES (1, 'Category1');
INSERT INTO Categories VALUES (2, 'Category2');
INSERT INTO Categories VALUES (3, 'Category3');
INSERT INTO Categories VALUES (4, 'Category4');
INSERT INTO Categories VALUES (5, 'Category5');

INSERT INTO ProductsCategories VALUES (1, 1);
INSERT INTO ProductsCategories VALUES (1, 2);
INSERT INTO ProductsCategories VALUES (2, 3);
INSERT INTO ProductsCategories VALUES (3, 2);
INSERT INTO ProductsCategories VALUES (3, 3);
INSERT INTO ProductsCategories VALUES (3, 4);

SELECT Products.[Name], Categories.[Name]
FROM Products
LEFT JOIN ProductsCategories ON Products.Id = ProductsCategories.ProductId
LEFT JOIN Categories ON ProductsCategories.CategoryId = Categories.Id