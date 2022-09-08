CREATE TABLE [dbo].[Department]
(
	[Id]	    UNIQUEIDENTIFIER	NOT NULL,
	[Name]		NVARCHAR(800)		NOT NULL,
	[Floor]		INT				    NOT NULL,

	CONSTRAINT [PK_Department] PRIMARY KEY ([Id])
)