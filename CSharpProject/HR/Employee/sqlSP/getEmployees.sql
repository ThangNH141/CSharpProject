use TSQLFundamentals2008
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
