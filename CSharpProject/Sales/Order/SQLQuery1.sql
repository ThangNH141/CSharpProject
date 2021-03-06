USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllOrder]    Script Date: 11/24/2016 8:32:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SelectAllOrder]
AS   
SELECT [orderid]
      ,[Orders].[custid]
	  ,[Customers].[contactname]
      ,[Orders].[empid]
	  ,[Employees].[firstname]
	  ,[Employees].[lastname]
      ,[orderdate]
      ,[requireddate]
      ,[shippeddate]
      ,[Orders].[shipperid]
	  ,[Shippers].[companyname]
      ,[freight]
      ,[shipname]
      ,[shipaddress]
      ,[shipcity]
      ,[shipregion]
      ,[shippostalcode]
      ,[shipcountry]
  FROM [Sales].[Orders]  
	LEFT JOIN  [Sales].[Customers]  ON [Customers].[custid] = [Orders].[custid]
	INNER JOIN  [HR].[Employees] ON [Employees].[empid] = [Orders].[empid]
	INNER JOIN  [Sales].[Shippers] ON [Shippers].[shipperid] = [Orders].[shipperid]
GO

CREATE PROCEDURE [dbo].[InsertOrder]
    @custid int,
	@empid int,
	@orderdate dateTime,
	@requireddate dateTime,
	@shippeddate dateTime,
	@shipperid int,
	@freight money,
	@shipname nvarchar(40),
	@shipaddress nvarchar(60),
	@shipcity nvarchar(15),
	@shipregion nvarchar(15),
	@shippostalcode nvarchar(10),
	@shipcountry nvarchar(15)
AS
BEGIN
INSERT INTO [Sales].[Orders]
           (
			[custid]
		   ,[empid]
           ,[orderdate]
           ,[requireddate]
           ,[shippeddate]
           ,[shipperid]
           ,[freight]
           ,[shipname]
           ,[shipaddress]
           ,[shipcity]
           ,[shipregion]
           ,[shippostalcode]
           ,[shipcountry])
     VALUES
           (
				@custid,
				@empid ,
				@orderdate ,
				@requireddate ,
				@shippeddate ,
				@shipperid ,
				@freight ,
				@shipname ,
				@shipaddress ,
				@shipcity ,
				@shipregion ,
				@shippostalcode ,
				@shipcountry 
           )
END
GO


CREATE PROCEDURE [dbo].[UpdateOrder]
	@orderid int,
    @custid int,
	@empid int,
	@orderdate dateTime,
	@requireddate dateTime,
	@shippeddate dateTime,
	@shipperid int,
	@freight money,
	@shipname nvarchar(40),
	@shipaddress nvarchar(60),
	@shipcity nvarchar(15),
	@shipregion nvarchar(15),
	@shippostalcode nvarchar(10),
	@shipcountry nvarchar(15)
AS
BEGIN
UPDATE [Sales].[Orders]
   SET [custid] = @custid
      ,[empid] = @empid
      ,[orderdate] = @orderdate
      ,[requireddate] = @requireddate
      ,[shippeddate] = @shippeddate
      ,[shipperid] = @shipperid
      ,[freight] = @freight
      ,[shipname] = @shipname
      ,[shipaddress] = @shipaddress
      ,[shipcity] = @shipcity
      ,[shipregion] = @shipregion
      ,[shippostalcode] = @shippostalcode
      ,[shipcountry] = @shippostalcode
 WHERE [Orders].orderid = @orderid
END
GO

CREATE PROCEDURE [dbo].[DeleteOrder]
	@orderid int
AS
BEGIN
DELETE FROM [Sales].[Orders]
      WHERE [Orders].[orderid] = @orderid
END
GO

CREATE PROCEDURE [dbo].[GetOrderDetail]
	@orderid int
AS
BEGIN
SELECT *  FROM [Sales].[OrderDetails]
      WHERE [OrderDetails].[orderid] = @orderid
END
GO




ALTER PROCEDURE [dbo].[SearchOrderByCustomerName]
    @SearchValue nvarchar(30)
AS
BEGIN
	SELECT [orderid]
      ,[Orders].[custid]
	  ,[Customers].[contactname]
      ,[Orders].[empid]
	  ,[Employees].[firstname]
	  ,[Employees].[lastname]
      ,[orderdate]
      ,[requireddate]
      ,[shippeddate]
      ,[Orders].[shipperid]
	  ,[Shippers].[companyname]
      ,[freight]
      ,[shipname]
      ,[shipaddress]
      ,[shipcity]
      ,[shipregion]
      ,[shippostalcode]
      ,[shipcountry]
	FROM 
		[Sales].[Orders]
		INNER JOIN  [Sales].[Customers]  ON [Customers].[custid] = [Orders].[custid] 
		INNER JOIN  [HR].[Employees] ON [Employees].[empid] = [Orders].[empid]
		INNER JOIN  [Sales].[Shippers] ON [Shippers].[shipperid] = [Orders].[shipperid]
	WHERE 
		[Orders].[custid] IN 
		(
			SELECT [custid]
			FROM [Sales].[Customers] 
			WHERE[Customers].[contactname] like '%'+@SearchValue+'%'
		)
	
END
GO

ALTER PROCEDURE [dbo].[SearchOrderByOrderDateRange]
    @FromDate Date,
    @ToDate Date
AS
BEGIN
	SELECT [orderid]
      ,[Orders].[custid]
	  ,[Customers].[contactname]
      ,[Orders].[empid]
	  ,[Employees].[firstname]
	  ,[Employees].[lastname]
      ,[orderdate]
      ,[requireddate]
      ,[shippeddate]
      ,[Orders].[shipperid]
	  ,[Shippers].[companyname]
      ,[freight]
      ,[shipname]
      ,[shipaddress]
      ,[shipcity]
      ,[shipregion]
      ,[shippostalcode]
      ,[shipcountry]
	FROM 
		[Sales].[Orders]
		INNER JOIN  [Sales].[Customers]  ON [Customers].[custid] = [Orders].[custid] 
		INNER JOIN  [HR].[Employees] ON [Employees].[empid] = [Orders].[empid]
		INNER JOIN  [Sales].[Shippers] ON [Shippers].[shipperid] = [Orders].[shipperid]
	WHERE 
		[Orders].[orderdate] >= @FromDate AND [Orders].[orderdate] <= @ToDate
	
END
GO


ALTER PROCEDURE [dbo].[SearchOrderByRequiredDateRange]
    @FromDate Date,
    @ToDate Date
AS
BEGIN
	SELECT [orderid]
      ,[Orders].[custid]
	  ,[Customers].[contactname]
      ,[Orders].[empid]
	  ,[Employees].[firstname]
	  ,[Employees].[lastname]
      ,[orderdate]
      ,[requireddate]
      ,[shippeddate]
      ,[Orders].[shipperid]
	  ,[Shippers].[companyname]
      ,[freight]
      ,[shipname]
      ,[shipaddress]
      ,[shipcity]
      ,[shipregion]
      ,[shippostalcode]
      ,[shipcountry]
	FROM 
		[Sales].[Orders]
		INNER JOIN  [Sales].[Customers]  ON [Customers].[custid] = [Orders].[custid] 
		INNER JOIN  [HR].[Employees] ON [Employees].[empid] = [Orders].[empid]
		INNER JOIN  [Sales].[Shippers] ON [Shippers].[shipperid] = [Orders].[shipperid]
	WHERE 
		[Orders].[requireddate] >= @FromDate AND [Orders].[requireddate] <= @ToDate
	
END
GO


ALTER PROCEDURE [dbo].[SearchOrderByShippedDateRange]
    @FromDate Date,
    @ToDate Date
AS
BEGIN
	SELECT [orderid]
      ,[Orders].[custid]
	  ,[Customers].[contactname]
      ,[Orders].[empid]
	  ,[Employees].[firstname]
	  ,[Employees].[lastname]
      ,[orderdate]
      ,[requireddate]
      ,[shippeddate]
      ,[Orders].[shipperid]
	  ,[Shippers].[companyname]
      ,[freight]
      ,[shipname]
      ,[shipaddress]
      ,[shipcity]
      ,[shipregion]
      ,[shippostalcode]
      ,[shipcountry]
	FROM 
		[Sales].[Orders]
		INNER JOIN  [Sales].[Customers]  ON [Customers].[custid] = [Orders].[custid] 
		INNER JOIN  [HR].[Employees] ON [Employees].[empid] = [Orders].[empid]
		INNER JOIN  [Sales].[Shippers] ON [Shippers].[shipperid] = [Orders].[shipperid]
	WHERE 
		[Orders].[shippeddate] >= @FromDate AND [Orders].[shippeddate] <= @ToDate
	
END
GO
