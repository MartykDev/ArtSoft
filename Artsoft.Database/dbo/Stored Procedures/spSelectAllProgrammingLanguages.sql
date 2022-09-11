CREATE PROCEDURE [dbo].[spSelectAllProgrammingLanguages]
AS
BEGIN
	
	SELECT * 
	FROM [dbo].[ProgrammingLanguage]
	ORDER BY [Name]

END