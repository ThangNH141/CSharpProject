use TSQLFundamentals2008
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertEmployees] 
	-- Add the parameters for the stored procedure here
	@Lastname nvarchar(20),
    @Firstname nvarchar(10),
    @Title nvarchar(30),
    @Titleofcourtesy nvarchar(25),
    @Birthdate datetime,
    @Hiredate datetime,
    @Address nvarchar(60),
    @City nvarchar(15),
    @Region nvarchar(15),
    @Postalcode nvarchar(10),
    @Country nvarchar(15),
    @Phone nvarchar(24),
    @Mgrid int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [TSQLFundamentals2008].[HR].[Employees]
           ([lastname]
           ,[firstname]
           ,[title]
           ,[titleofcourtesy]
           ,[birthdate]
           ,[hiredate]
           ,[address]
           ,[city]
           ,[region]
           ,[postalcode]
           ,[country]
           ,[phone]
           ,[mgrid])
     VALUES
     (@Lastname, @Firstname, @Title, @Titleofcourtesy, @Birthdate, @Hiredate,
     @Address, @City, @Region, @Postalcode,@Country, @Phone, @Mgrid)
END
GO
