USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[DELETE_CUSTOMER]    Script Date: 11/26/2016 13:15:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DELETE_CUSTOMER]
	@custid int
AS
BEGIN
	DELETE FROM Sales.Customers
	WHERE custid=@custid
END