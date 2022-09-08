CREATE TABLE [dbo].[ProgrammingLanguage]
(
	[Id]	    UNIQUEIDENTIFIER	NOT NULL,
	[Name]		NVARCHAR(800)		NOT NULL,

	CONSTRAINT [PK_ProgrammingLanguage] PRIMARY KEY ([Id])
)