CREATE PROCEDURE [dbo].[spSelectAllEmployees]
AS
BEGIN
	
	SELECT *
	FROM [dbo].[vEmployee] AS E
	ORDER BY E.[Name], E.[Surname]

END