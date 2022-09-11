CREATE PROCEDURE [dbo].[spSelectAllDepartments]
AS
BEGIN
	
	SELECT * 
	FROM [dbo].[Department]
	ORDER BY [Name]

END