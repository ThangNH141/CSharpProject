-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
use TSQLFundamentals2008
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
