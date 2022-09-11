CREATE PROCEDURE [dbo].[spSelectExistingEmployeeNames]
(
    @term NVARCHAR(200)
)
AS
BEGIN
	
	SELECT TOP 10
		E.[Name]
	FROM [dbo].[Employee] AS E
	WHERE E.[Name] LIKE '%' + @term + '%'
	ORDER BY E.[Name]

END