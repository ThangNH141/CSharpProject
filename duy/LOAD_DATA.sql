USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[LOAD_DATA]    Script Date: 11/26/2016 13:18:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[LOAD_DATA]
	
AS
BEGIN
	SELECT * FROM Sales.Customers
END
