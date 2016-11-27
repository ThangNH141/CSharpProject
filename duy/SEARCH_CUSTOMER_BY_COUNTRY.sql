USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_CUSTOMER_BY_COUNTRY]    Script Date: 11/26/2016 13:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SEARCH_CUSTOMER_BY_COUNTRY]
	@value nvarchar(100)
AS
BEGIN
	SELECT *
	FROM Sales.Customers
	WHERE country = @value
END
