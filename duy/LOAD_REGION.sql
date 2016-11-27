USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[LOAD_REGION]    Script Date: 11/26/2016 13:18:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[LOAD_REGION]
	
AS
BEGIN
	SELECT region
	FROM Sales.Customers
	GROUP BY region
END
