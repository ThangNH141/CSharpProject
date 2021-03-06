USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[ADD_CUSTOMER]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADD_CUSTOMER]
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

GO
/****** Object:  StoredProcedure [dbo].[ADD_SHIPPER]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADD_SHIPPER]
	@companyname nvarchar(40),
	@phone nvarchar(24)
AS
BEGIN
	INSERT INTO Sales.Shippers(companyname, phone)
	VALUES (@companyname, @phone) 
END

GO
/****** Object:  StoredProcedure [dbo].[AddCategories]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCategories]
	
	
	@categoryname nvarchar(15),
    @description nvarchar(200)
   

AS
BEGIN
	Insert into [Production].[Categories](categoryname,[description])
	
	
	
	values (@categoryname ,@description  )

END
GO
/****** Object:  StoredProcedure [dbo].[AddSupplier]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddSupplier] 
	
	
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
	Insert into Production.Suppliers(companyname, contactname,contacttitle,[address],city,region,postalcode,country,phone,fax)
	values (@companyname ,@contactname ,@contacttitle ,@address ,@city ,@region ,@postalcode, @country ,@phone ,@fax )

END


GO
/****** Object:  StoredProcedure [dbo].[DELETE_CUSTOMER]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DELETE_CUSTOMER]
	@custid int
AS
BEGIN
	DELETE FROM Sales.Customers
	WHERE custid=@custid
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_SHIPPER]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DELETE_SHIPPER]
	@shipperid int
AS
BEGIN
	DELETE FROM Sales.Shippers
	WHERE shipperid=@shipperid
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteCategories]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCategories]
	@categoryid int
	
AS
BEGIN
	

   delete 
	from [Production].[Categories] 
	
	Where categoryid = @categoryid
END


GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployee]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BAONQ>
-- Create date: <Create Date,,>
-- Description:	<Delete Employee,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteEmployee] 
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM HR.Employees WHERE empid = @id;
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteOrder]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteOrder]
	@orderid int
AS
BEGIN
DELETE FROM [Sales].[Orders]
      WHERE [Orders].[orderid] = @orderid
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteSupplier]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteSupplier] 
	
	@supplierid int
	

AS
BEGIN
	delete 
	from Production.Suppliers	 
	Where supplierid = @supplierid

END


GO
/****** Object:  StoredProcedure [dbo].[GET_CUSTOMER_NAME]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_CUSTOMER_NAME]
	@custid int
AS
BEGIN
	SELECT contactname
	FROM Sales.Customers
	WHERE custid = @custid
END


GO
/****** Object:  StoredProcedure [dbo].[getEmployees]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BAONQSE61774>
-- Description:	<GET ALL EMPLOYEE>
-- =============================================
CREATE PROCEDURE [dbo].[getEmployees]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM HR.Employees
END

GO
/****** Object:  StoredProcedure [dbo].[GetOrderDetail]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOrderDetail]
	@orderid int
AS
BEGIN
SELECT *  FROM [Sales].[OrderDetails]
      WHERE [OrderDetails].[orderid] = @orderid
END

GO
/****** Object:  StoredProcedure [dbo].[InsertEmployees]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertEmployees] 
	-- Add the parameters for the stored procedure here
	@Lastname nvarchar(20),
    @Firstname nvarchar(10),
    @Title nvarchar(30),
    @Titleofcourtesy nvarchar(25),
    @Birthdate datetime,
    @Hiredate datetime,
    @Address nvarchar(60),
    @City nvarchar(15),
    @Region nvarchar(15),
    @Postalcode nvarchar(10),
    @Country nvarchar(15),
    @Phone nvarchar(24),
    @Mgrid int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [TSQLFundamentals2008].[HR].[Employees]
           ([lastname]
           ,[firstname]
           ,[title]
           ,[titleofcourtesy]
           ,[birthdate]
           ,[hiredate]
           ,[address]
           ,[city]
           ,[region]
           ,[postalcode]
           ,[country]
           ,[phone]
           ,[mgrid])
     VALUES
     (@Lastname, @Firstname, @Title, @Titleofcourtesy, @Birthdate, @Hiredate,
     @Address, @City, @Region, @Postalcode,@Country, @Phone, @Mgrid)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertOrder]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[LOAD_COUNTRY]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAD_COUNTRY] 

AS
BEGIN
	SELECT country
	FROM Sales.Customers
	GROUP BY country
END
GO
/****** Object:  StoredProcedure [dbo].[LOAD_DATA]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAD_DATA]
	
AS
BEGIN
	SELECT * FROM Sales.Customers
END

GO
/****** Object:  StoredProcedure [dbo].[LOAD_REGION]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAD_REGION]
	
AS
BEGIN
	SELECT region
	FROM Sales.Customers
	GROUP BY region
END

GO
/****** Object:  StoredProcedure [dbo].[LOAD_SHIPPERS]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAD_SHIPPERS]
	
AS
BEGIN
	SELECT *
	FROM Sales.Shippers
END

GO
/****** Object:  StoredProcedure [dbo].[LoadCategories]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoadCategories] 

AS
BEGIN
	

    
	SELECT * FROM [Production].[Categories]
END


GO
/****** Object:  StoredProcedure [dbo].[LoadCountru]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoadCountru]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [country]From [Production].[Suppliers] 
END


GO
/****** Object:  StoredProcedure [dbo].[LoadCountry]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoadCountry]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [country]From [Production].[Suppliers] 
END


GO
/****** Object:  StoredProcedure [dbo].[LoadRegion]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoadRegion]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [region]From [Production].[Suppliers]
	GROUP BY region
END


GO
/****** Object:  StoredProcedure [dbo].[LoadRigion]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LoadRigion]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [region]From [Production].[Suppliers] 
END


GO
/****** Object:  StoredProcedure [dbo].[LoadSuppliers]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LoadSuppliers]
	
AS
BEGIN
	SELECT *
	FROM Production.Suppliers
END


GO
/****** Object:  StoredProcedure [dbo].[RELOAD_UPDATE_DATA]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RELOAD_UPDATE_DATA]
	@custid int
AS
BEGIN
	SELECT *
	FROM Sales.Customers
	WHERE custid=@custid
END

GO
/****** Object:  StoredProcedure [dbo].[SEARCH_CUSTOMER_BY_COMPANYNAME]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SEARCH_CUSTOMER_BY_COMPANYNAME]
	@value nvarchar(100)
AS
BEGIN
	SELECT *
	FROM Sales.Customers
	WHERE companyname LIKE '%' + @value + '%'
END

GO
/****** Object:  StoredProcedure [dbo].[SEARCH_CUSTOMER_BY_CONTACTNAME]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SEARCH_CUSTOMER_BY_CONTACTNAME]
	@value nvarchar(100)
AS
BEGIN
	SELECT *
	FROM Sales.Customers
	WHERE contactname LIKE '%' + @value + '%'
END

GO
/****** Object:  StoredProcedure [dbo].[SEARCH_CUSTOMER_BY_COUNTRY]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SEARCH_CUSTOMER_BY_COUNTRY]
	@value nvarchar(100)
AS
BEGIN
	SELECT *
	FROM Sales.Customers
	WHERE country = @value
END

GO
/****** Object:  StoredProcedure [dbo].[SEARCH_SHIPPER_BY_COMPANYNAME]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SEARCH_SHIPPER_BY_COMPANYNAME]
	@value nvarchar(100)
AS
BEGIN
	SELECT *
	FROM Sales.Shippers
	WHERE companyname LIKE '%' + @value + '%'
END

GO
/****** Object:  StoredProcedure [dbo].[SEARCH_SHIPPER_BY_PHONE]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SEARCH_SHIPPER_BY_PHONE]
	@value nvarchar(100)
AS
BEGIN
	SELECT *
	FROM Sales.Shippers
	WHERE phone LIKE '%' + @value + '%'
END

GO
/****** Object:  StoredProcedure [dbo].[SearchCategories]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SearchCategories]
	@value nvarchar(100)
AS
BEGIN
	SELECT *
	FROM [Production].[Categories]
	WHERE categoryname LIKE '%' + @value + '%'
END


GO
/****** Object:  StoredProcedure [dbo].[SearchCompany]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchCompany]
	@value nvarchar(100)
AS
BEGIN
	SELECT *
	FROM Production.Suppliers
	WHERE companyname LIKE '%' + @value + '%'
END


GO
/****** Object:  StoredProcedure [dbo].[SearchContactName]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchContactName]
	@value nvarchar(100)
AS
BEGIN
	SELECT *
	FROM Production.Suppliers
	WHERE contactname LIKE '%' + @value + '%'
END


GO
/****** Object:  StoredProcedure [dbo].[SearchEmployees]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BAONQ>
-- Create date: <Create Date,,>
-- Description:	<Serach employee>
-- =============================================
CREATE PROCEDURE [dbo].[SearchEmployees] 
	-- Add the parameters for the stored procedure here
	@Firstname nvarchar(10),
	@Lastname nvarchar(20),
	@BirthdateF datetime,
	@BirthdateT datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    IF(@Firstname IS not null)  SELECT * FROM HR.Employees WHERE firstname LIKE '%' + @Firstname + '%'
    ELSE IF(@Lastname is not NULL)  SELECT * FROM HR.Employees WHERE lastname LIKE '%' + @Lastname + '%'
	ELSE IF(@BirthdateF is not NULL) SELECT * FROM HR.Employees WHERE birthdate >= @BirthdateF AND birthdate <= @BirthdateT
END

GO
/****** Object:  StoredProcedure [dbo].[SearchOrderByCustomerName]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchOrderByCustomerName]
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
/****** Object:  StoredProcedure [dbo].[SearchOrderByOrderDateRange]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SearchOrderByOrderDateRange]
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
/****** Object:  StoredProcedure [dbo].[SearchOrderByRequiredDateRange]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchOrderByRequiredDateRange]
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
/****** Object:  StoredProcedure [dbo].[SearchOrderByShippedDateRange]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchOrderByShippedDateRange]
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
/****** Object:  StoredProcedure [dbo].[SelectAllOrder]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllOrder]
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
/****** Object:  StoredProcedure [dbo].[SreachCountry]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SreachCountry]
	@value nvarchar(100)
AS
BEGIN
	SELECT *
	FROM Production.Suppliers
	WHERE country = @value
END


GO
/****** Object:  StoredProcedure [dbo].[UPDATE_CUSTOMER]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_CUSTOMER]
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

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_SHIPPER]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_SHIPPER]
	@shipperid int,
	@companyname nvarchar(40),	
	@phone nvarchar(24)
AS
BEGIN
	UPDATE Sales.Shippers
	SET companyname=@companyname, phone=@phone
	WHERE shipperid=@shipperid
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateCategories]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateCategories]
	@categoryid int,
	@categoryname nvarchar(15),
    @description nvarchar(200)
AS
BEGIN
	

   UPDATE [Production].[Categories]
	SET categoryname= @categoryname,[description]= @description
	Where categoryid = @categoryid
END


GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployee]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BAONQ>
-- Create date: <Create Date,,>
-- Description:	<Delete Employee,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateEmployee] 
	-- Add the parameters for the stored procedure here
	@ID int,
	@Lastname nvarchar(20),
    @Firstname nvarchar(10),
    @Title nvarchar(30),
    @Titleofcourtesy nvarchar(25),
    @Birthdate datetime,
    @Hiredate datetime,
    @Address nvarchar(60),
    @City nvarchar(15),
    @Region nvarchar(15),
    @Postalcode nvarchar(10),
    @Country nvarchar(15),
    @Phone nvarchar(24),
    @Mgrid int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE HR.Employees SET lastname=@Lastname,firstname=@Firstname,title=@Title,titleofcourtesy=@Titleofcourtesy,
						 birthdate=@Birthdate,hiredate=@Hiredate,[address]=@Address,
						 city=@City, region=@Region,postalcode=@Postalcode,country=@Country,phone=@Phone,
						 mgrid=@Mgrid WHERE empid=@ID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateOrder]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[UpdateSupplier]    Script Date: 11/27/2016 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateSupplier] 
	
	@supplierid int,
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
	UPDATE Production.Suppliers
	SET companyname=@companyname,contactname=@contactname, contacttitle= @contacttitle, [address] = @address,city= @city, 
	region = @region,postalcode = @postalcode,country=@country,phone = @phone ,fax = @fax
	Where supplierid = @supplierid

END


GO
