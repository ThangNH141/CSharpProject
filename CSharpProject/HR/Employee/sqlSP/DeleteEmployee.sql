USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployee]    Script Date: 11/25/2016 15:05:03 ******/
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
