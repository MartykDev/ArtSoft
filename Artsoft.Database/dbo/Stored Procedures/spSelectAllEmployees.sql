CREATE PROCEDURE [dbo].[spSelectAllEmployees]
AS
BEGIN
	
	SELECT 
		E.[Id]
	   ,E.[Name]
	   ,E.[Surname]
	   ,E.[Age]
	   ,E.[Gender]

	   ,D.[Id] AS [Department.Id]
	   ,D.[Name] AS [Department.Name]
	   ,D.[Floor] AS [Department.Floor]

	   ,PL.[Id] AS [ProgrammingLanguage.Id]
	   ,PL.[Name] AS [ProgrammingLanguage.Name]
	FROM [dbo].[Employee] AS E
		INNER JOIN [dbo].[Department] AS D ON D.[Id] = E.[DepartmentId]
		INNER JOIN [dbo].[ProgrammingLanguage] AS PL ON Pl.[Id] = E.[ProgrammingLanguageId]

END