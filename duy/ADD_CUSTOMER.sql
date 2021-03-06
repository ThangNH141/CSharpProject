USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[ADD_CUSTOMER]    Script Date: 11/26/2016 13:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ADD_CUSTOMER]
	@companyname nvarchar(40),
	@contactname nvarchar(30),
	@contacttitle nvarchar(30),
	@address nvarchar(60),
	@city nvarchar(15),
	@region nvarchar(15),
	@postalcode nvarchar(10),
	@country nvarchar(15),
	@phone nvarchar(24),
	@fax nvarchar(24)
AS
BEGIN
	INSERT INTO Sales.Customers (companyname, contactname, contacttitle, [address], city, region, postalcode,
				country, phone, fax)
	VALUES (@companyname, @contactname, @contacttitle, @address, @city, @region, @postalcode, @country, @phone, @fax)
END
