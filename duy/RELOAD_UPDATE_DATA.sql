USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[RELOAD_UPDATE_DATA]    Script Date: 11/26/2016 13:18:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[RELOAD_UPDATE_DATA]
	@custid int
AS
BEGIN
	SELECT *
	FROM Sales.Customers
	WHERE custid=@custid
END
