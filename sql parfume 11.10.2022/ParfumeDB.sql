create database ParfumeDB


create table Brands
(
Id int identity primary key,
BrandName nvarchar(30) not null
);


create table Category
(
Id int identity primary key,
CategoryName nvarchar(200) not null
);
create table Users 
(
Id int identity primary key,
UserName nvarchar(200) not null,
[Name] nvarchar(200) not null,
Surname nvarchar(20) not null,
Gender  BIT,
Phone nvarchar(20),
Email nvarchar(50),
[Password] nvarchar(50) not null default '123456'
);

create table Parfums
(
Id int identity primary key,
ParfumeName nvarchar(200),
Gramm int not null default 0,
BrandId int foreign key  REFERENCES Brands(Id),
CategoryId int foreign key  REFERENCES Category(Id),
SaleStatus BIT,
Price float(50) not null default 0.0

);

create table [Order]
(
Id int identity primary key,
ParfumeId int foreign key  REFERENCES Parfums(Id),
UserId int foreign key  REFERENCES Users(Id),
[Count] int not null default 0
);

--view


create view ShowParfume as
select Parfums.Id,Parfums.ParfumeName,Brands.BrandName,Category.CategoryName,Parfums.Price
from Parfums
inner join Brands on Parfums.BrandId = Brands.Id
inner join Category on Parfums.CategoryId = Category.Id

select * from ShowParfume


--
--
--



create view ShowOrderData as
select 
o.Id,
u.UserName ,
p.ParfumeName,
p.Price,
o.[Count],
b.BrandName,
c.CategoryName
from [Order] o
inner join Users u on  o.UserId = u.Id 
inner join Parfums p on o.ParfumeId = p.Id
inner join Category c on p.CategoryId = c.Id
inner join Brands b on p.BrandId = b.Id
 
 select * from ShowOrderData



-- end view 



-- procedures 
create procedure usp_InsertParfume 
@ParfumeNamee nvarchar(50),
@gramm int,
@brandId int,
@CategoryId int,
@SaleStatus BIT,
@Price float(50)
as
INsert into Parfums (ParfumeName, Gramm, BrandId,CategoryId,SaleStatus,Price)
values
(@ParfumeNamee,@gramm,@brandId,@CategoryId,@SaleStatus,@Price)






