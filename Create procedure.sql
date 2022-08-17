CREATE PROCEDURE [dbo].[AddCustomer]
(
 @Id varchar(50),
 @UCCNo varchar(50),
 @Name varchar(100),
 @Gender varchar(50),
 @DOB datetime,
 @EmailID varchar(100),
 @Mobile varchar(20),
 @Landline varchar(20),
 @Address varchar(500),
 @PinCode varchar(20),
 @DepositoryType varchar(20),
 @PanCardNo varchar(50),
 @Details varchar(max)
)
AS
BEGIN
	insert into [dbo].[Customers] values(@Id,@UCCNo,@Name,@Gender,@DOB,@EmailID,@Mobile,@Landline,@Address,@PinCode,@DepositoryType,@PanCardNo,@Details)
End
