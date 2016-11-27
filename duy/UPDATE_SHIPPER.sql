USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_SHIPPER]    Script Date: 11/26/2016 13:20:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UPDATE_SHIPPER]
	@shipperid int,
	@companyname nvarchar(40),	
	@phone nvarchar(24)
AS
BEGIN
	UPDATE Sales.Shippers
	SET companyname=@companyname, phone=@phone
	WHERE shipperid=@shipperid
END
