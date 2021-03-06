Select * FROM Products  WHERE CategoryID = 1 or CategoryID = 3 

Select * From Products Where CategoryID = 1 and CategoryID = 3 and UnitPrice >= 10

SELECT * FROM Products where CategoryID = 1 order by UnitPrice desc

SELECT Count(*) Adet from Products

Select CategoryID, Count(*) UrunSayisi from Products  where UnitPrice > 20 group by CategoryID having Count(*) < 10-- ID GÖRE LISTELE GRUP OLARAK

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where UnitPrice >= 10


-- DTO Data Transformation Object

Select * From Products left join [Order Details]
on Products.ProductID = [Order Details].ProductID

Select * from Customers customer left join Orders orders
on customer.CustomerID = orders.CustomerID -- Customer da olup orders da olmayanları da getir left join.
where orders.CustomerID is null -- Orders.CustomerID deki kişiler bizden hiç ürün almamış









