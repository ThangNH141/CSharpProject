USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_SHIPPER_BY_PHONE]    Script Date: 11/26/2016 13:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SEARCH_SHIPPER_BY_PHONE]
	@value nvarchar(100)
AS
BEGIN
	SELECT *
	FROM Sales.Shippers
	WHERE phone LIKE '%' + @value + '%'
END
