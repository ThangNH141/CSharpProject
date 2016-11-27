USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[GET_CUSTOMER_NAME]    Script Date: 11/26/2016 13:16:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GET_CUSTOMER_NAME]
	@custid int
AS
BEGIN
	SELECT contactname
	FROM Sales.Customers
	WHERE custid = @custid
END
