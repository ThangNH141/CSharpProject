USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[ADD_SHIPPER]    Script Date: 11/26/2016 13:14:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ADD_SHIPPER]
	@companyname nvarchar(40),
	@phone nvarchar(24)
AS
BEGIN
	INSERT INTO Sales.Shippers(companyname, phone)
	VALUES (@companyname, @phone) 
END
