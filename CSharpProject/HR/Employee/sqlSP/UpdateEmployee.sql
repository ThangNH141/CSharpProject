USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployee]    Script Date: 11/25/2016 15:06:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BAONQ>
-- Create date: <Create Date,,>
-- Description:	<Delete Employee,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateEmployee] 
	-- Add the parameters for the stored procedure here
	@ID int,
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
	UPDATE HR.Employees SET lastname=@Lastname,firstname=@Firstname,title=@Title,titleofcourtesy=@Titleofcourtesy,
						 birthdate=@Birthdate,hiredate=@Hiredate,[address]=@Address,
						 city=@City, region=@Region,postalcode=@Postalcode,country=@Country,phone=@Phone,
						 mgrid=@Mgrid WHERE empid=@ID
END
