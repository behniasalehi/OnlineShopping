use OnlineShopping
go
create PROCEDURE dbo.usp_Insert_Category
  @InsertCategory as dbo.udt_Insert_Category readonly,
  @message nvarchar(300) output
AS
begin tran 
begin try
insert into dbo.Category(CategoryName , Descriptions)
select * from @InsertCategory
set @message='Insert is done successfully.'
commit tran 
end try
begin catch 
set @message='Unsuccessful' + ERROR_MESSAGE();
rollback tran 
end catch 
go
