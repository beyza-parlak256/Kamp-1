--Select // yorum satırı
--ANSII
-- * tümü demek

Select ContactName Adi, CompanyName SirketAdi, City  Sehir  from Customers -- bu satır aslında bir tablo

Select * from Customers where City = 'London' -- Şehri London olanları seç

-- case insensitive(büyük küçük harf duyarsız)
select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice >= 20

select * from Products order by ProductName -- ürün ismine göre sırala, order by -> sırala

select * from Products order by UnitPrice desc --ascending(asc (artan)) --descending (desc(düşen))

Select count(*) from Products -- count(*) tüm satırları say demek

Select count(*) from Products where CategoryID = 2

-- hangi kategoride kaç farklı ürün var? (bütün kategorileri tekrar etmeyecek şekilde listele)
Select categoryId,count(*) from Products group by CategoryID

-- içinde 10 taneden az ürün çeşidi olan kategori
Select categoryId,count(*) from Products group by CategoryID having count(*) < 10

Select count(*) Adet from Products 

Select categoryID, count(*) from products where UnitPrica > 20
group by CategorID having count(*) < 10

Select Products.ProductID, Products.ProductName, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
-- DTO (Data Transformation Object)

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null