USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_CUSTOMER]    Script Date: 11/26/2016 13:20:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UPDATE_CUSTOMER]
	@custid int,
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
	UPDATE Sales.Customers
	SET companyname=@companyname, contactname=@contactname, contacttitle=@contacttitle, [address]=@address,
	city=@city, region=@region, postalcode=@postalcode, country=@country, phone=@phone, fax=@fax
	WHERE custid=@custid
END
