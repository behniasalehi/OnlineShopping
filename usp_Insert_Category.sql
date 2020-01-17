use OnlineShopping
go
alter PROCEDURE dbo.usp_Insert_Category
  @InsertCategory as dbo.udt_Insert_Category readonly
AS
begin tran 
begin try
insert into dbo.Category(CategoryName , Descriptions)
select CategoryName,Descriptions from @InsertCategory
commit tran 
end try
begin catch 
rollback tran 
end catch 
go
