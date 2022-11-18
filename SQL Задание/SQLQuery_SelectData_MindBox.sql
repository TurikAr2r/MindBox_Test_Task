/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT 
	   Products.[Name] as ProductName
      ,Categories.Name as CategoryName

  FROM [TestBd].[dbo].[Products]
  left join ProductCategory as pc on pc.ProductId = Products.Id
  left join Categories on Categories.Id = pc.CategoryId