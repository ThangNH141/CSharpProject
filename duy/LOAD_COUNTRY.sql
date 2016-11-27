USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[LOAD_COUNTRY]    Script Date: 11/26/2016 13:17:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[LOAD_COUNTRY] 

AS
BEGIN
	SELECT country
	FROM Sales.Customers
	GROUP BY country
END