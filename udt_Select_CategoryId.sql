use OnlineShopping
go
create  Type dbo.udt_Select_CategoryId as Table(
					CategoryName nvarchar(50),
					Id int
)