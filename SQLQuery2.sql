﻿--Select 
--ANSII
select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'London'
--case insensitivive
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>10

select * from Products where CategoryID=1 order by UnitPrice desc --ascending   --decending

select count(*) Adet from Products where CategoryID=2

select CategoryID,count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10

select * from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object 

select*from Products p left join [Order Details] od 
on p.ProductID =od.ProductID

select * from Customers c left join Orders o 
on c.CustomerID =o.CustomerID
where o.CustomerID is null

