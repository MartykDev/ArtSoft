CREATE TYPE [dbo].[udtEmployee] AS TABLE
(
	[Id]					 UNIQUEIDENTIFIER	NOT NULL,
	[Name]					 NVARCHAR(200)		NOT NULL,
	[Surname]				 NVARCHAR(200)		NOT NULL,
	[Age]					 INT				NOT NULL,
	[Gender]				 INT				NOT NULL,
	[DepartmentId]			 UNIQUEIDENTIFIER	NOT NULL,
	[ProgrammingLanguageId]  UNIQUEIDENTIFIER	NOT NULL
)