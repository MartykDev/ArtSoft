CREATE TABLE [dbo].[Employee]
(
	[Id]					 UNIQUEIDENTIFIER	NOT NULL,
	[Name]					 NVARCHAR(200)		NOT NULL,
	[Surname]				 NVARCHAR(200)		NOT NULL,
	[Age]					 INT				NOT NULL,
	[Gender]				 INT				NOT NULL,
	[DepartmentId]			 UNIQUEIDENTIFIER	NOT NULL,
	[ProgrammingLanguageId]  UNIQUEIDENTIFIER	NOT NULL,

	CONSTRAINT [PK_Employee] PRIMARY KEY ([Id]),

    CONSTRAINT [FK_Employee_To_Department] FOREIGN KEY ([DepartmentId]) REFERENCES [Department]([Id]),
    CONSTRAINT [FK_Employee_To_ProgrammingLanguage] FOREIGN KEY ([ProgrammingLanguageId]) REFERENCES [ProgrammingLanguage]([Id])
)