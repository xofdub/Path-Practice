USE [funWithMatt]
GO

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

--Author: Matt Spezia
--Date 01/17/2017
--Description: Path and Enpoint Practice with Eric


CREATE PROCEDURE sp_ReadFunUser

AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @v_error VARCHAR(255),
	@v_errorNo INT 
	
	BEGIN TRY
	
		SELECT
			usr.userID,
			usr.email,
			usr.passwordHash

		FROM userData AS usr

	END TRY

	BEGIN CATCH

		SELECT @v_error = ERROR_MESSAGE()
		SELECT @v_errorNo = ERROR_NUMBER()

		RAISERROR('Database error occurred %s"',16,1,@v_error)
		RETURN -20000

	END CATCH

END


			
