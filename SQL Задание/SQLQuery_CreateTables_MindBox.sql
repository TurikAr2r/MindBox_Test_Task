
CREATE TABLE Products
(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(MAX),
    Description NVARCHAR(MAX),
)


CREATE TABLE Categories
(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(20),
    Description NVARCHAR(MAX)
)

CREATE TABLE ProductCategory
(
    
  ProductId int,
  CategoryId int,
  constraint PK_ProductCategory primary key (productId, CategoryId)
)

INSERT INTO Products (Name, Description)
Values
( 'iPhone', 'nice phone'),
( 'Laptop', 'nice laptop'),
( 'Charger', 'for charge battery'),
( 'Napkins for display', 'why?'),
( 'smart-watch', 'just watches')

Insert into Categories (Name)
values
('Equipment'),
('Accessories'),
('Kitchen')