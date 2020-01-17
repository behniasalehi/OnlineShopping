use OnlineShopping
go
alter  PROCEDURE dbo.usp_Delete_Category
  @DeleteCategory as dbo.udt_Delete_Category readonly
AS
begin tran 
begin try
DELETE FROM dbo.Category WHERE CategoryID = (select Id from @DeleteCategory);
commit tran 
end try
begin catch 
rollback tran 
end catch 
go
exec dbo.usp_Delete_Category
