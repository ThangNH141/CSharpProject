USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[LOAD_SHIPPERS]    Script Date: 11/26/2016 13:18:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[LOAD_SHIPPERS]
	
AS
BEGIN
	SELECT *
	FROM Sales.Shippers
END
