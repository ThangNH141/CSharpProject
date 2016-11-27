USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[DELETE_SHIPPER]    Script Date: 11/26/2016 13:15:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_SHIPPER]
	@shipperid int
AS
BEGIN
	DELETE FROM Sales.Shippers
	WHERE shipperid=@shipperid
END