use OnlineShopping
go
create PROCEDURE dbo.usp_Insert_Product
  @InsertProduct as dbo.udt_Insert_Product readonly
AS
begin tran 
begin try
insert into dbo.Product(Category_Ref , ProductName , UnitPrice , Quantiy , Discount , ProductImage)
select Category_Ref, ProductName , UnitPrice , Quantiy , Discount , ProductImage  from @InsertProduct
commit tran 
end try
begin catch 
rollback tran 
end catch 
go
exec dbo.usp_Insert_Product	
