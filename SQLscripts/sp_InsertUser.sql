CREATE PROCEDURE sp_InsertUser
(
	@email NVARCHAR(100)
)

AS 
	
	INSERT INTO UserData (Email) VALUES (@email)



GO