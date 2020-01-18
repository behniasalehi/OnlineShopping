use OnlineShopping
go
create  PROCEDURE dbo.usp_Select_CategoryId
@CategoryInfo as dbo.udt_Select_CategoryId readonly
AS
begin tran 
begin try
	select  c.CategoryId
	from dbo.Category c 
	where c.categoryName like (select CategoryName from @CategoryInfo )
	
commit tran 
end try
begin catch 
	
rollback tran 
end catch 
go
