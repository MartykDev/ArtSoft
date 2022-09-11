CREATE PROCEDURE [dbo].[spMergeEmployees]
(
	@employee [dbo].[udtEmployee] READONLY
)
AS
BEGIN

	MERGE INTO [dbo].[Employee] AS TARGET
		USING @employee AS SOURCE ON TARGET.[Id] = SOURCE.[Id]
		WHEN NOT MATCHED BY TARGET THEN
		INSERT
		(
			[Id]
		   ,[Name]
		   ,[Surname]
		   ,[Age]
		   ,[Gender]
		   ,[DepartmentId]
		   ,[ProgrammingLanguageId]
		)
		VALUES
		(
			SOURCE.[Id]
		   ,SOURCE.[Name]
		   ,SOURCE.[Surname]
		   ,SOURCE.[Age]
		   ,SOURCE.[Gender]
		   ,SOURCE.[DepartmentId]
		   ,SOURCE.[ProgrammingLanguageId]
		)
		WHEN MATCHED THEN
			UPDATE SET
				TARGET.[Name] = SOURCE.[Name]
			   ,TARGET.[Surname] = SOURCE.[Surname]
			   ,TARGET.[Age] = SOURCE.[Age]
			   ,TARGET.[Gender] = SOURCE.[Gender]
			   ,TARGET.[DepartmentId] = SOURCE.[DepartmentId]
			   ,TARGET.[ProgrammingLanguageId] = SOURCE.[ProgrammingLanguageId];

END